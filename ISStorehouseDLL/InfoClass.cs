using ISStorehouseDLL.Models;
using Realms;
using System;
using System.Linq;

namespace ISStorehouseDLL
{
    public class InfoClass
    {
        public async void SendToCell(string physicAddress, byte color0, byte color2, byte effect)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);

            realm.Write(() =>
            {

                address.Color1 = color0;
                address.Color2 = color2;
                address.Effect = effect;
                address.Modify = true;
            });

            realm.Dispose();
        }
        
        public async void SendToCells(string physicAddress, byte color0, byte color2, byte effect)
        {
            var realm = await Realm.GetInstanceAsync();
            var address = realm.All<Storehouse>().FirstOrDefault(
                x => x.PhysicAddress == physicAddress);

            realm.Write(() =>
            {
                address.Color1 = color0;
                address.Color2 = color2;
                address.Effect = effect;
                address.Modify = true;
            });

            realm.Dispose();
        }

        public string GetCellInformation(int modul, int row, int collumn)
        {
            var realm = Realm.GetInstance();
            var Modul = realm.All<Storehouse>()
                .FirstOrDefault(x => x.Module == modul && x.Row == row && x.Collumn == collumn);
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

        public void CellInfo()
        {

        }

        /// <summary>
        /// Get information about a list of cells from database
        /// </summary>
        public void CellListInfo()
        {
            throw new NotSupportedException();
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
