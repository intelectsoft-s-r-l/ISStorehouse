using ISStorehouseDLL;
using ISStorehouseDLL.Common;
using ISStorehouseService.Responsed;
using System;
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

        //TODO: VERIFY async of diagnose
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
        //TODO: VERIFY async of diagnose
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

        public async Task<string> SendListCells(string address)
        {
            string message;
            try
            {
                Info.SendToCells(address);
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
            }

            return message;
        }

        public async Task<string> ClearListCells()
        {
            throw new NotImplementedException();
        }

        public async Task<string> SingleCellInfo(string address)
        {
            throw new NotImplementedException();
        }

        public async Task<string> CellListInfo()
        {
            throw new NotImplementedException();
        }

        public enum Status
        {
            Disabled,    //0
            Active,      //1
            Diagnose     //2 
        }

        public enum BaseColors
        {
            Red = 1,
            Green = 2,
            Blue = 3,
        }

        public enum Colors
        {
            Black,          // 0
            Red,            // 1
            Green,          // 2
            Blue,           // 3
            Yellow,         // 4
            Aqua,           // 5
            Magenda,        // 6
            White           // 6
        }

        public enum Effects
        {
            NoEffect,             // 0
            Blink,                // 1
            DoubleBlink,          // 2
        }

        public enum Respond
        {
            OK = 200,
            Bad_Request = 500,
        }

    }
}
