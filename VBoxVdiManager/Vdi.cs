using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using VBoxVdiManager.Model;

namespace VBoxVdiManager
{
    public static class Vdi
    {
        public static object ReadVdi(string fileName)
        {
            var vdiInfo = new VdiFileInfo();
            try
            {
                using (var fs = File.Open(fileName, FileMode.Open))
                {
                    vdiInfo.InitialText = fs.ReadAsciiString(64);
                    vdiInfo.ImageSignature = fs.ReadInt();
                    vdiInfo.Version = new VdiVersion(
                        fs.ReadShort(),
                        fs.ReadShort());
                    vdiInfo.HeaderSize = fs.ReadInt();
                    vdiInfo.ImageType = fs.ReadInt();
                    vdiInfo.ImageFlags = new BitVector32(fs.ReadInt());
                    vdiInfo.ImageDescritpion = fs.ReadUtf8String(0x154 - 0x54);
                    vdiInfo.OffsetBlocks = fs.ReadInt();
                    vdiInfo.OffsetData = fs.ReadInt();
                    vdiInfo.Cylinders = fs.ReadInt();
                    vdiInfo.Heads = fs.ReadInt();
                    vdiInfo.Sectors = fs.ReadInt();
                    vdiInfo.SectorSize = fs.ReadInt();
                    fs.ReadInt();
                    vdiInfo.DiskSize = fs.ReadLong();
                    vdiInfo.BlockSize = fs.ReadInt();
                    vdiInfo.BlockExtraData = fs.ReadInt();
                    vdiInfo.BlocksInHDD = fs.ReadInt();
                    vdiInfo.BlocksAllocated = fs.ReadInt();
                    vdiInfo.UUID = fs.ReadGuid();
                    vdiInfo.SnapshotUUID = fs.ReadGuid();
                    vdiInfo.LinkUUID = fs.ReadGuid();
                    vdiInfo.ParentUUID = fs.ReadGuid();
                }
            }
            catch (Exception ex)
            {

            }

            return vdiInfo;
        }

        private static string ReadAsciiString(this FileStream fs, int length)
        {
            var buffer = new byte[length];
            fs.Read(buffer, 0, length);
            var result = Encoding.ASCII.GetString(buffer);
            return result;
        }

        private static string ReadUtf8String(this FileStream fs, int length)
        {
            var buffer = new byte[length];
            fs.Read(buffer, 0, length);
            var result = Encoding.UTF8.GetString(buffer);
            return result;
        }

        private static Guid ReadGuid(this FileStream fs)
        {
            var buffer = new byte[16];
            fs.Read(buffer, 0, 16);
            var result = new Guid(buffer);
            return result;
        }

        private static short ReadShort(this FileStream fs)
        {
            var bytes = new byte[2];
            fs.Read(bytes, 0, 2);
            return (short)(bytes[0]
                + (bytes[1] << 8));
        }

        private static int ReadInt(this FileStream fs)
        {
            var bytes = new byte[4];
            fs.Read(bytes, 0, 4);
            return bytes[0]
                + (bytes[1] << 8)
                + (bytes[2] << 16)
                + (bytes[3] << 24);
        }

        private static long ReadLong(this FileStream fs)
        {
            var bytes = new byte[8];
            fs.Read(bytes, 0, 8);
            return bytes[0]
                + ((long)bytes[1] << 8)
                + ((long)bytes[2] << 16)
                + ((long)bytes[3] << 24)
                + ((long)bytes[4] << 32)
                + ((long)bytes[5] << 40)
                + ((long)bytes[6] << 48)
                + ((long)bytes[7] << 56);
        }
    }
}
