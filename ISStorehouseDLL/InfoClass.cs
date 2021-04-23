using ISStorehouseDLL.Common;
using ISStorehouseDLL.Models;
using Realms;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ISStorehouseDLL
{
    public class InfoClass
    {
        private Settings Settings = new Settings();
        public async Task SendToCell(string physicAddress, byte color0, byte color2, byte effect)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);

            try
            {
                realm.Write(() =>
                {
                    address.Color1 = color0;
                    address.Color2 = color2;
                    address.Effect = effect;
                    address.Modify = true;
                });     
            }
            catch (Exception ex)
            {

            }

            realm.Dispose();
        }

        public async Task ClearCell(string physicAddress)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);
            try
            {
                realm.Write(() =>
                {
                    address.Color1 = Convert.ToByte(Settings.Colors.Black);
                    address.Color2 = Convert.ToByte(Settings.Colors.Black);
                    address.Effect = Convert.ToByte(Settings.Effects.NoEffect);
                    address.Modify = true;
                });
            }
            catch(Exception ex)
            {

            }


            realm.Dispose();
        }

        public async void SendToCells(string physicAddress)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);

            Random rnd = new Random();
            foreach (object element in physicAddress)
            {
                int color = rnd.Next(1, 7);
                SendToCell(element.ToString(), Convert.ToByte(color), Convert.ToByte(0), 1);

            }

            realm.Dispose();
        }

        public string CellInfo(string address)
        {
            var realm = Realm.GetInstance();
            var Modul = realm.All<Storehouse>()
                .FirstOrDefault(x => x.Address == address);
            string Response;

            if (Modul != null)
            {
                Response = "Cell has color " + Modul.Color1 + " and another color " + Modul.Color2 + " with efect " + Modul.Effect;
            }
            else
            {
                Response = "Cell is empty";
            }


            return Response;
            realm.Dispose();
        }

        /// <summary>
        /// Get information about a list of cells from database
        /// </summary>
        public void CellListInfo(object address)
        {
            throw new NotImplementedException();
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
