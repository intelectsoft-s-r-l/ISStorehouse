using Realms;

namespace ISStorehouseDLL.Models
{
    public class Storehouse : RealmObject
    {
        public string PhysicAddress { get; set; }
        public string Address { get; set; }
        public byte Effect { get; set; }
        public byte Color1 { get; set; }
        public byte Color2 { get; set; }
        public bool Modify { get; set; }
        public short Module { get; set; }
        public short Row { get; set; }
        public short Collumn { get; set; }
    }
}
