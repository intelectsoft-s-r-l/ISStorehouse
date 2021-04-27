using ISStorehouseDLL.Common;
using ISStorehouseDLL.Models;
using Realms;
using System;
using System.Linq;
using System.Threading.Tasks;
using static ISStorehouseDLL.Common.Settings;

namespace ISStorehouseDLL
{
    public class InfoClass
    {
        private Settings Settings = new Settings();
        public async Task<string> SendToCell(string physicAddress, byte color0, byte color2, byte effect)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);
            var status = realm.All<Moduls>().FirstOrDefault(
                x => x.Module == address.Module && x.Status == Convert.ToInt32(Status.Diagnose));
            string message;

            if (status != null)
            {
                return message = "Modul is in diagnose";
            }
            else
            {
                try
                {
                    realm.Write(() =>
                    {
                        address.Color1 = color0;
                        address.Color2 = color2;
                        address.Effect = effect;
                        address.Modify = true;
                    });

                    message = Respond.OK.ToString();
                }
                catch (Exception ex)
                {
                    message = Respond.Bad_Request + " " + ex.ToString();
                }
            }

            realm.Dispose();
            return message;
        }

        public async Task<string> ClearCell(string physicAddress)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);
            var status = realm.All<Moduls>().FirstOrDefault(
                x => x.Module == address.Module && x.Status == Convert.ToInt32(Status.Diagnose));
            string message;

            if (status != null)
            {
                return message = "Modul is in diagnose";
            }
            else
            {
                try
                {
                    message = Respond.OK.ToString();
                    realm.Write(() =>
                    {
                        address.Color1 = Convert.ToByte(Settings.Colors.Black);
                        address.Color2 = Convert.ToByte(Settings.Colors.Black);
                        address.Effect = Convert.ToByte(Settings.Effects.NoEffect);
                        address.Modify = true;
                    });
                }
                catch (Exception ex)
                {
                    message = Respond.Bad_Request + " " + ex.ToString();
                }
            }


            return message;
            realm.Dispose();
        }

        public async Task<string> SendToCells(string physicAddress)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);
            var status = realm.All<Moduls>().FirstOrDefault(
               x => x.Module == address.Module && x.Status == Convert.ToInt32(Status.Diagnose));
            string message;

            if (status != null)
            {
                return message = "Modul is in diagnose";
            }
            else
            {
                Random rnd = new Random();
                foreach (object element in physicAddress)
                {
                    int color = rnd.Next(1, 7);
                    SendToCell(element.ToString(), Convert.ToByte(color), Convert.ToByte(0), 1);
                }
                message = Respond.OK.ToString();
            }


            realm.Dispose();
            return message;
        }

        public object CellInfo(string address)
        {
            var realm = Realm.GetInstance();
            var Modul = realm.All<Storehouse>()
                .FirstOrDefault(x => x.PhysicAddress == address);
            object Response;

            if (Modul != null)
            {
                if (Modul.Color1 == 0 && Modul.Color1 == 0)
                {
                    Response = "Address " + Modul.PhysicAddress + " is clear.";
                }
                else
                {
                    Response = "Address " + Modul.PhysicAddress + " has colors " + Modul.Color1 + " and " + Modul.Color2 + ", with effect " + Modul.Effect;
                }
            }
            else
            {
                Response = null;
            }

            realm.Dispose();
            return Response;
        }


        /// <summary>
        /// verify if modul is busy
        /// </summary>
        //public List<object> BusyModul(int modul)
        //{
        //    var realm = Realm.GetInstance();
        //    var Storehouse = realm.All<Storehouse>();
        //    List<object> Response = new List<object>();

        //    foreach(var store in Storehouse)
        //    {
        //        if(store.Effect != 0)
        //        {
        //            Response.AddRange()
        //    }


        //    realm.Dispose();
        //}

    }
}
