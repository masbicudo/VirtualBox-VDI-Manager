using System;
using System.IO;
using System.Linq;
using System.Xml;

namespace VBoxVdiManager
{
    public static class Vbox
    {
        public static VboxFileInfo ReadVbox(string filePath)
        {
            using (var fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var xmlReader = new XmlTextReader(fs))
            {
                xmlReader.Namespaces = false;
                var xml = new XmlDocument();
                xml.Load(xmlReader);

                var vboxInfo = new VboxFileInfo();

                var root = xml.DocumentElement;

                var machine = root.SelectSingleNode("Machine");

                vboxInfo.UUID = Guid.Parse(machine.Attributes["uuid"]?.Value);
                vboxInfo.Name = machine.Attributes["name"]?.Value;
                vboxInfo.OSType = machine.Attributes["OSType"]?.Value;
                vboxInfo.SnapshotFolder = machine.Attributes["snapshotFolder"]?.Value;

                var storageControllers = machine.SelectNodes("StorageControllers/StorageController");
                vboxInfo.StorageControllers.AddRange(storageControllers
                    .OfType<XmlNode>()
                    .Select(x =>
                    {
                        var sc = new StorageController
                        {
                            Name = x.Attributes["name"].Value,
                            Type = x.Attributes["type"].Value,
                        };

                        sc.AttachedDevices.AddRange(x.SelectNodes("AttachedDevice").OfType<XmlNode>().Select(ad => new AttachedDevice
                        {
                            Type = ad.Attributes["type"].Value,
                            ImageUUID = ad.ChildNodes.Count > 0 ? Guid.Parse(ad.SelectSingleNode("Image").Attributes["uuid"].Value) : Guid.Empty,
                        }));

                        return sc;
                    }));

                return vboxInfo;
            }
        }
    }
}
