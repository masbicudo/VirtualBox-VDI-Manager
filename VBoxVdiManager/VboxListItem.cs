using System;
using System.Collections.Generic;
using System.IO;

namespace VBoxVdiManager
{
    public class VboxListItem :
        IComparable<VboxListItem>
    {
        public VboxFileInfo VboxInfo { get; set; }
        public string FilePath { get; set; }

        public override string ToString()
        {
            return Path.GetFileName(this.FilePath);
        }

        int IComparable<VboxListItem>.CompareTo(VboxListItem other)
        {
            return Comparer<string>.Default.Compare(this.FilePath, other.FilePath);
        }
    }
}
