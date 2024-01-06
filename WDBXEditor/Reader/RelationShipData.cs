using System.Collections.Generic;

namespace WDBXEditor.Reader
{
    public class RelationShipData
    {
        public uint Records;
        public uint MinId;
        public uint MaxId;
        public Dictionary<uint, byte[]> Entries; // index, id
    }
}
