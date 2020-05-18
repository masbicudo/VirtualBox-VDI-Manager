using System;
using System.Collections.Generic;
using System.IO;
using VBoxVdiManager.Model;

namespace VBoxVdiManager
{
    public class VdiListItem :
        IComparable<VdiListItem>
    {
        public object VdiInfo { get; set; }
        public string FilePath { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return Path.GetFileName(this.FilePath);
        }

        int IComparable<VdiListItem>.CompareTo(VdiListItem other)
        {
            return Comparer<string>.Default.Compare(this.FilePath, other.FilePath);
        }
    }
}
