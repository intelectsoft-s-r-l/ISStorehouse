using Realms;
using System;

namespace ISStorehouseDLL.Models
{
    public class Moduls : RealmObject
    {
        public short RegModule { get; set; }
        public short Module { get; set; }
        public short Rows { get; set; }
        public short Collumns { get; set; }
        public string Prefix { get; set; }
        public int Status { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public DateTimeOffset ModifyTime { get; set; }
    }
}
