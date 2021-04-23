using ISStorehouseDLL;
using ISStorehouseDLL.Common;
using ISStorehouseService.Responsed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;

namespace ISStorehouseService
{
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, MaxItemsInObjectGraph = 2147483647, IncludeExceptionDetailInFaults = true)]
    public class StorehouseService : IStorehouseService
    {
        private Settings Settings = new Settings();
        private InfoClass Info = new InfoClass();
        private ScanClass Scan = new ScanClass();

        public async Task<string> DiagnoseAllStorehouse()
        {
            string message;
            try
            {
                Thread AllModulsDiagThread = new Thread(() => Settings.AllModulsDiagnose());
                AllModulsDiagThread.Start();
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }
            return message;
        }

        public async Task<string> DiagnoseOneModul(short modul)
        {
            string message;
            try
            {
                Thread OneModulDIagThread = new Thread(() => Settings.OneModulTest(modul));
                OneModulDIagThread.Start();
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }

            return message;
        }

        public async Task<string> ClearAllStorehouse()
        {
            string message;
            try
            {
                Scan.ClearAllModuls();
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }

            return message;
        }

        public async Task<string> ClearOneModul(int modul)
        {
            string message;
            try
            {
                Scan.ClearOneModul(modul);
                message = Respond.OK.ToString();

            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }

            return message;
        }

        public async Task<string> SendSingleCell(string address, byte color1, byte color2, byte effect)
        {
            string message;
            try
            {
                Info.SendToCell(address, color1, color2, effect);
                message = Respond.OK.ToString();


            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }
            return message;
        }

        public async Task<string> ClearSingleCell(string address)
        {
            string message;

            try
            {
                Info.ClearCell(address);
                message = Respond.OK.ToString();

            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }
            return message;
        }

        public async Task<string> SendListCells(object addresses)
        {
            string message;
            List<string> result = addresses.ToString().Trim(' ').Split(',').ToList();
            try
            {
                Random rnd = new Random();
                foreach (var element in result)
                {
                    int color = rnd.Next(1, 8);
                    Info.SendToCell(element.ToString(), Convert.ToByte(color), Convert.ToByte(0), 2);
                }
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }

            return message;
        }

        public async Task<string> ClearListCells(object addresses)
        {
            string message;
            List<string> result = addresses.ToString().Trim(' ').Split(',').ToList();
            try
            {
                foreach (var element in result)
                {
                    Info.ClearCell(element);
                }
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }

            return message;
        }

        public async Task<string> SingleCellInfo(string address)
        {
            string message;
            try
            {
                message = Info.CellInfo(address);
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }
            return message;
        }

        public async Task<string> CellListInfo(object addresses)
        {
            string message;
            List<string> result = addresses.ToString().Trim(' ').Split(',').ToList();
            try
            {
                foreach (var element in result)
                {
                    message = Info.CellInfo(element);
                }
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }
            return message;
        }

        public enum Respond
        {
            OK = 200,
            Bad_Request = 500,
        }

    }
}
