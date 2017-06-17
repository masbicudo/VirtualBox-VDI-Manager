using System;
using System.Collections.Specialized;

namespace VBoxVdiManager
{
    public class VdiFileInfo
    {
        public string InitialText { get; set; }
        public int ImageSignature { get; set; }
        public VdiVersion Version { get; set; }
        public int HeaderSize { get; set; }
        public int ImageType { get; set; }
        public BitVector32 ImageFlags { get; set; }
        public string ImageDescritpion { get; set; }
        public int OffsetBlocks { get; set; }
        public int OffsetData { get; set; }
        public int Cylinders { get; set; }
        public int Heads { get; set; }
        public int Sectors { get; set; }
        public int SectorSize { get; set; }
        public long DiskSize { get; set; }
        public int BlockSize { get; set; }
        public int BlockExtraData { get; set; }
        public int BlocksInHDD { get; set; }
        public int BlocksAllocated { get; set; }
        public Guid UUID { get; set; }
        public Guid SnapshotUUID { get; set; }
        public Guid LinkUUID { get; set; }
        public Guid ParentUUID { get; set; }
    }
}
