using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VBoxVdiManager.Model;

namespace VBoxVdiManager
{
    public partial class Form1 : Form,
        IComparer<VdiFileInfo>
    {
        private Dictionary<string, VdiFileInfo> dicVdisByPath
            = new Dictionary<string, VdiFileInfo>(StringComparer.InvariantCultureIgnoreCase);

        private Dictionary<Guid, VdiFileInfo> dicVdisByGuid
            = new Dictionary<Guid, VdiFileInfo>();

        public Form1()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (File.Exists("config.json"))
            {
                var text = File.ReadAllText("config.json");
                var json = JsonConvert.DeserializeObject<Config>(text);

                if (json.WindowLocation != null)
                    this.Location = json.WindowLocation.Value;

                if (json.WindowSize != null)
                    this.Size = json.WindowSize.Value;

                if (json.WindowState != null)
                    this.WindowState = json.WindowState.Value;

                if (json.Path != null)
                    this.txtVdiPath.Text = json.Path;

                if (json.TopSplitter != null)
                    this.splitContainer1.SplitterDistance = json.TopSplitter.Value;

                if (json.MiddleSplitter != null)
                    this.splitContainer3.SplitterDistance = json.MiddleSplitter.Value;

                if (json.BottomSplitter != null)
                    this.splitContainer2.SplitterDistance = json.BottomSplitter.Value;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            var json = new Config();

            json.WindowLocation = this.WindowState == FormWindowState.Normal
                ? this.Location
                : this.RestoreBounds.Location;

            json.WindowSize = this.WindowState == FormWindowState.Normal
                ? this.Size
                : this.RestoreBounds.Size;

            json.WindowState = this.WindowState;

            json.Path = this.txtVdiPath.Text;

            json.TopSplitter = this.splitContainer1.SplitterDistance;
            json.MiddleSplitter = this.splitContainer3.SplitterDistance;
            json.BottomSplitter = this.splitContainer2.SplitterDistance;

            var text = JsonConvert.SerializeObject(json);
            File.WriteAllText("config.json", text);
        }

        private void btnLoadVdi_Click(object sender, EventArgs e)
        {
            var path = this.txtVdiPath.Text;

            if (File.Exists(path) && !path.EndsWith("/") && !path.EndsWith("\\"))
            {
                var vdiInfo = Vdi.ReadVdi(path);
                this.pgVdi.SelectedObject = vdiInfo;

                var vdiItem = new VdiListItem
                {
                    FilePath = path,
                    VdiInfo = vdiInfo,
                };

                this.lstVdis.Items.Add(vdiItem);
            }
            else if (Directory.Exists(path))
            {
                path = path.TrimEnd('\\', '/');
                var filesNames = Directory.GetFiles(path, "*.vdi", SearchOption.AllDirectories);

                var vdiItems = filesNames.Select(x => new VdiListItem
                {
                    FilePath = x,
                    VdiInfo = Vdi.ReadVdi(x),
                })
                .ToArray();

                this.lstVdis.Items.AddRange(vdiItems);

                var vboxFilesNames = Directory.GetFiles(path, "*.vbox", SearchOption.AllDirectories);

                var vboxItems = vboxFilesNames.Select(x => new VboxListItem
                {
                    FilePath = x,
                    VboxInfo = Vbox.ReadVbox(x),
                })
                .ToArray();

                this.lstVboxs.Items.AddRange(vboxItems);
            }
            else
            {
                // Error
            }
        }

        private void lstVdis_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pgVdi.SelectedObject = (this.lstVdis.SelectedItem as VdiListItem)?.VdiInfo;
            this.pgVdi.ExpandAllGridItems();
        }

        private void lstVboxs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pgVbox.SelectedObject = (this.lstVboxs.SelectedItem as VboxListItem)?.VboxInfo;
            this.pgVbox.ExpandAllGridItems();
        }

        private void btnRebuild_Click(object sender, EventArgs e)
        {
            var dicVdi = new Dictionary<Guid, VdiListItem>();
            foreach (var vdiItem in this.lstVdis.Items.Cast<VdiListItem>())
                if (vdiItem.VdiInfo is VdiFileInfo info)
                    dicVdi.Add(info.UUID, vdiItem);

            foreach (var vboxItem in this.lstVboxs.CheckedItems.Cast<VboxListItem>())
                this.RebuildVboxFile(vboxItem, dicVdi);
        }

        private void RebuildVboxFile(VboxListItem vboxItem, Dictionary<Guid, VdiListItem> dicVdi)
        {
            var strBuilder = new StringBuilder();
            bool inHardDisks = false;
            bool inMediaRegistry = false;
            string result;
            bool mediaRegistryFound = false;
            var mediaRegistrySkipped = false;
            bool hardDisksFound = false;
            bool hardDisksSkipped = false;

            using (var fs = File.Open(vboxItem.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var sr = new StreamReader(fs, Encoding.UTF8))
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if (line == "    <MediaRegistry>")
                    {
                        mediaRegistryFound = true;
                        inMediaRegistry = true;
                    }

                    if (line == "    <ExtraData>" || line.StartsWith("    <Hardware>"))
                    {
                        mediaRegistrySkipped = !mediaRegistryFound;
                    }

                    if (inMediaRegistry && !hardDisksFound && line == "    </MediaRegistry>")
                        hardDisksSkipped = true;

                    if (line == "      <HardDisks>" || line == "      <HardDisks/>" || mediaRegistrySkipped || hardDisksSkipped)
                    {
                        inHardDisks = true;

                        if (mediaRegistrySkipped)
                            strBuilder.AppendLine("    <MediaRegistry>");

                        strBuilder.AppendLine("      <HardDisks>");

                        foreach (var hdUuid in vboxItem.VboxInfo.StorageControllers.SelectMany(x => x.AttachedDevices).Where(x => x.Type == "HardDisk").Select(x => x.ImageUUID))
                        {
                            var stack = new Stack<VdiListItem>();
                            var curUuid = hdUuid;
                            while (curUuid != Guid.Empty)
                            {
                                VdiListItem curVdi;
                                if (!dicVdi.TryGetValue(curUuid, out curVdi))
                                    return;
                                stack.Push(curVdi);
                                curUuid = ((VdiFileInfo)curVdi.VdiInfo).LinkUUID;
                            }

                            var levels = stack.Count;
                            for (var i = 0; i < levels; i++)
                            {
                                var vdiItem = stack.Pop();
                                var typeStr = ((VdiFileInfo)vdiItem.VdiInfo).ImageType == 1 ? @" type=""Normal""" : "";
                                var selfClosing = i + 1 == levels ? "/" : "";
                                strBuilder.AppendLine("      " + new string(' ', (i + 1) * 2) + $@"<HardDisk uuid=""{{{((VdiFileInfo)vdiItem.VdiInfo).UUID}}}"" location=""{vdiItem.FilePath.Replace('\\', '/')}"" format=""VDI""{typeStr}{selfClosing}>");
                            }

                            for (var i = 1; i < levels; i++)
                            {
                                strBuilder.AppendLine("      " + new string(' ', (levels - i) * 2) + $@"</HardDisk>");
                            }
                        }

                        strBuilder.AppendLine("      </HardDisks>");

                        if (line == "    </MediaRegistry>")
                        {
                            inMediaRegistry = false;
                            inHardDisks = false;
                            strBuilder.AppendLine(line);
                        }

                        if (line == "      <HardDisks/>" || mediaRegistrySkipped)
                            inHardDisks = false;

                        if (mediaRegistrySkipped)
                        {
                            strBuilder.AppendLine("    </MediaRegistry>");
                            strBuilder.AppendLine(line);
                            inHardDisks = false;
                            mediaRegistrySkipped = false;
                        }

                        hardDisksSkipped = false;
                        mediaRegistrySkipped = false;
                        hardDisksFound = true;
                        mediaRegistryFound = true;

                        continue;
                    }
                    else if (line == "      </HardDisks>")
                    {
                        inHardDisks = false;
                        continue;
                    }

                    if (!inHardDisks)
                        strBuilder.AppendLine(line);
                }

            result = strBuilder.ToString();

            var bak = vboxItem.FilePath + ".bak";
            if (File.Exists(bak))
                File.Delete(bak);
            File.Move(vboxItem.FilePath, bak);

            File.WriteAllText(vboxItem.FilePath, result);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            var dicVdi = new Dictionary<Guid, VdiListItem>();
            foreach (var vdiItem in this.lstVdis.Items.Cast<VdiListItem>())
                if (vdiItem.VdiInfo is VdiFileInfo info)
                    dicVdi.Add(info.UUID, vdiItem);

            foreach (var vboxItem in this.lstVboxs.CheckedItems.Cast<VboxListItem>())
            {
                var bak = vboxItem.FilePath + ".bak";
                if (File.Exists(bak))
                {
                    File.Delete(vboxItem.FilePath);
                    File.Move(bak, vboxItem.FilePath);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int it = 0; it < this.lstVboxs.Items.Count; it++)
                this.lstVboxs.SetItemChecked(it, true);
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            for (int it = 0; it < this.lstVboxs.Items.Count; it++)
                this.lstVboxs.SetItemChecked(it, false);
        }

        private void lstVdis_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var lb = (ListBox)sender;

            //var size = g.MeasureString(
            //    "" + lb.Items[e.Index],
            //    lb.Font,
            //    e.Bounds.Size,
            //    StringFormat.GenericTypographic);

            //var width = size.Width + 16;

            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index >= 0)
            {
                e.Graphics.DrawString(
                    "" + lb.Items[e.Index],
                    lb.Font,
                    Brushes.Red,
                    e.Bounds.X,
                    e.Bounds.Y);
            }
        }

        int IComparer<VdiFileInfo>.Compare(VdiFileInfo x, VdiFileInfo y)
        {
            var px = x.GetPath(this.GetParent).Select(v => v.UUID).Reverse();
            var py = y.GetPath(this.GetParent).Select(v => v.UUID).Reverse();

            var res = EnumerableComparer<Guid>.Default.Compare(px, py);

            return res;
        }

        private VdiFileInfo GetParent(VdiFileInfo v)
        {
            VdiFileInfo res;
            this.dicVdisByGuid.TryGetValue(v.LinkUUID, out res);
            return res;
        }
    }

    public class Config
    {
        public string Path { get; set; }
        public Point? WindowLocation { get; set; }
        public Size? WindowSize { get; set; }
        public FormWindowState? WindowState { get; set; }
        public int? TopSplitter { get; set; }
        public int? MiddleSplitter { get; set; }
        public int? BottomSplitter { get; set; }
    }
}
