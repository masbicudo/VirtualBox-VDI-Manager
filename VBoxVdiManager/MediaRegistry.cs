using System.Collections.Generic;

namespace VBoxVdiManager
{
    public class MediaRegistry
    {
        public List<HardDisk> HardDisks { get; } = new List<HardDisk>();
        public List<DVDImage> DVDImages { get; } = new List<DVDImage>();
    }
}
