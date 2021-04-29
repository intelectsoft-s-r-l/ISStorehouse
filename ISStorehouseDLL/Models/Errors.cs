using Realms;
using System;

namespace ISStorehouseDLL.Models
{
    public class Errors : RealmObject
    {
        public short Module { get; set; }
        public short Rows { get; set; }
        public short Collumns { get; set; }
        public short OverflowErrCount { get; set; }
        public short IlegalDataValueCount { get; set; }
        public short IlegalDataAddressCount { get; set; }
        public short IlegatFunctionCount { get; set; }
        public short CheckSumErrCount { get; set; }
        public short TotoalErr { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
