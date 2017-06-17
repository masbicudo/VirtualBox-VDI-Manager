using System;
using System.Collections.Generic;

namespace VBoxVdiManager
{
    public class VboxFileInfo
    {
        public Guid UUID { get; set; }
        public string Name { get; set; }
        public string OSType { get; set; }
        public string SnapshotFolder { get; set; }
        public MediaRegistry MediaRegistry { get; } = new MediaRegistry();
        public List<StorageController> StorageControllers { get; } = new List<StorageController>();
    }
}
