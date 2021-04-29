using ISStorehouseDLL.Common;
using ISStorehouseDLL.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using static ISStorehouseDLL.Common.Settings;

namespace ISStorehouseDLL
{
    public class ScanClass
    {
        private Modbus modbus = new Modbus();

        public string ClearAllModuls()
        {

            var realm = Realm.GetInstance();
            var moduls = realm.All<Storehouse>();


            foreach (var modul in moduls)
            {
                realm.Write(() =>
                {
                    modul.Color1 = Convert.ToByte(Colors.Black);
                    modul.Color2 = Convert.ToByte(Colors.Black);
                    modul.Effect = Convert.ToByte(Effects.NoEffect);
                    modul.Modify = true;
                });


            }
            realm.Dispose();
            return "All moduls are cleard";
        }
        public string ClearOneModul(int modul)
        {
            var realm = Realm.GetInstance();
            var Modul = realm.All<Moduls>().FirstOrDefault(x => x.Module == modul);
            var deposit = realm.All<Storehouse>();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.Module == Modul.Module);
            var status = realm.All<Moduls>().FirstOrDefault(
                x => x.Module == address.Module && x.Status == Convert.ToInt32(Status.Diagnose));
            string message;

            if (status != null)
            {
                return message = "Modul is in diagnose";
            }
            else
            {

                foreach (var depo in deposit)
                {
                    if (depo.Module == Modul.Module)
                    {
                        realm.Write(() =>
                        {
                            depo.Color1 = Convert.ToByte(Colors.Black);
                            depo.Color2 = Convert.ToByte(Colors.Black);
                            depo.Effect = Convert.ToByte(Effects.NoEffect);
                            depo.Modify = true;
                        });
                    }

                }
                message = Respond.OK.ToString();
            }

            realm.Dispose();
            return message;
        }

        public void GenerateAddreses()
        {
            var realm = Realm.GetInstance();
            var AllModuls = realm.All<Moduls>();

            foreach (var row in AllModuls)
            {
                for (int x = 0; x <= row.Rows; x++)
                {
                    for (int y = 0; y <= row.Collumns; y++)
                    {
                        realm.Write(() =>
                        {
                            realm.Add(new Storehouse()
                            {
                                PhysicAddress = row.Module.ToString("00") + x.ToString() + y.ToString("00"),
                                Address = row.Prefix + row.Module.ToString("00") + x.ToString() + y.ToString("00"),
                                Module = row.Module,
                                Row = Convert.ToInt16(x),
                                Collumn = Convert.ToInt16(y),

                            });

                        });
                    }
                }
            }

            realm.Dispose();
        }


        public List<object> DisplayModules()
        {
            var realm = Realm.GetInstance();
            var AllModuls = realm.All<Moduls>();
            string[] Modul;
            List<object> ModuleList = new List<object>();

            foreach (var modul in AllModuls)
            {
                var model = (modul.Module, modul.Rows, modul.Collumns, modul.Prefix);
                ModuleList.Add(model);

            }
            return ModuleList;
            realm.Dispose();
        }

    }
}
