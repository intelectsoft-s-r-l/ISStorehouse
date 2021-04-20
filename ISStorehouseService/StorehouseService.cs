using ISStorehouseDLL;
using ISStorehouseDLL.Common;
using System;
using System.Collections.Generic;
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
        //private readonly ILogger<StorehouseService> _logger;
        private Settings Settings = new Settings();
        private InfoClass Info = new InfoClass();
        private ScanClass Scan = new ScanClass();

        public StorehouseService(/*ILogger<StorehouseService> logger*/)
        {
            //_logger = logger;
        }

        public async Task DiagnoseAllStorehouse()
        {
            Settings.AllModulsDiagnose();
        }

        public async Task DiagnoseOneModul(int modul)
        {
            throw new NotImplementedException();
        }

        public async Task ClearAllStorehouse()
        {
            throw new NotImplementedException();
        }

        public async Task ClearOneModul(int modul)
        {
            Scan.ClearOneModul(modul);
        }

        public async Task SendSingleCell(string address, byte color1, byte color2, byte effect)
        {
            Info.SendToCell(address, color1, color2, effect);

        }

        public async Task SendListCells()
        {
            throw new NotImplementedException();
        }

        public async Task SingleCellInfo()
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
