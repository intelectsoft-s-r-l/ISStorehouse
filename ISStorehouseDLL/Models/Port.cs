using Realms;
using System;

namespace ISStorehouseDLL.Models
{
    public class Port : RealmObject
    {
        public string ComPort { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
