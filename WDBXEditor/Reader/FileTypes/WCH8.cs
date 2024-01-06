using System.IO;
using WDBXEditor.Storage;

namespace WDBXEditor.Reader.FileTypes
{
    internal class WCH8 : WCH7
    {
        public WCH8()
        {
            StringTableOffset = 0x14;
            HeaderSize = 0x34;
        }

        public WCH8(string filename)
        {
            StringTableOffset = 0x14;
            HeaderSize = 0x34;
            FileName = filename;
        }

        public override void WriteRecordPadding(BinaryWriter bw, DBEntry entry, long offset)
        {
            if (!HasOffsetTable && bw.BaseStream.Position - offset < RecordSize)
                bw.BaseStream.Position += (RecordSize - (bw.BaseStream.Position - offset));
        }
    }
}
