using ISStorehouseDLL;
using ISStorehouseDLL.Common;
using ISStorehouseService.Responsed;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
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
        private SHService SHService = new SHService();
        private BaseResponsed responsed = new BaseResponsed();

        public StorehouseService()
        {
        }

        public async Task DiagnoseAllStorehouse()
        {
            try
            {
                Settings.AllModulsDiagnose();
            }
            catch (Exception ex)
            {
                SHService.EventLog.WriteEntry(ex.ToString());
            }
        }

        public async Task DiagnoseOneModul(short modul)
        {
            try
            {
                Settings.OneModulTest(modul);

            }
            catch (Exception ex)
            {
                SHService.EventLog.WriteEntry(ex.ToString());
            }
        }

        public async Task ClearAllStorehouse()
        {
            try
            {
                Scan.ClearAllModuls();
                
            }
            catch (Exception ex)
            {
                SHService.EventLog.WriteEntry(ex.ToString());
            }

        }

        public async Task ClearOneModul(int modul)
        {
            try
            {
                Scan.ClearOneModul(modul);

            }
            catch (Exception ex)
            {
                SHService.EventLog.WriteEntry(ex.ToString());
            }
        }

        public async Task<string> SendSingleCell(string address, byte color1, byte color2, byte effect)
        {
            try
            {
                Info.SendToCell(address, color1, color2, effect);

            }
            catch (Exception ex)
            {
                SHService.EventLog.WriteEntry(ex.ToString());
            }
            return address;

        }

        public async Task SendListCells(string address)
        {
            try
            {
                Info.SendToCells(address);

            }
            catch (Exception ex)
            {
                SHService.EventLog.WriteEntry(ex.ToString());
            }
        }

        public async Task SingleCellInfo(int modul)
        {
            throw new NotImplementedException();
        }

        public async Task CellListInfo()
        {
            throw new NotImplementedException();
        }

        public enum Status
        {
            Disabled,    //0
            Active       //1
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

    }
}
