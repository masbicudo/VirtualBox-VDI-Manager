using System.Collections.Generic;

namespace VBoxVdiManager.Model
{
    public class StorageController
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<AttachedDevice> AttachedDevices { get; } = new List<AttachedDevice>();
    }
}
