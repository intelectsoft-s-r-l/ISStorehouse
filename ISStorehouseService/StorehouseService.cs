using ISStorehouseDLL;
using ISStorehouseDLL.Common;
using NLog;
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
        private Settings _settings = new Settings();
        private InfoClass _info = new InfoClass();
        private ScanClass _scan = new ScanClass();
        private CancellationTokenSource _tokenSource;
        protected Logger _logger = LogManager.GetCurrentClassLogger();

        public async Task<string> DiagnoseOneModul(short modul)
        {
            _tokenSource = new CancellationTokenSource();
            var token = _tokenSource.Token;

            string message;
            try
            {
                Thread Diagnose = new Thread(() => _settings.OneModulTest(modul, token));
                Diagnose.Start();
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = ex.ToString();
                _logger.Error(ex, "DiagnoseOneModul");
            }

            return message;
        }

        public async Task<string> DiagnoseAllStorehouse()
        {
            _tokenSource = new CancellationTokenSource();
            var token = _tokenSource.Token;

            string message;
            try
            {
                Thread Diagnose = new Thread(() => _settings.AllModulsDiagnose(token));
                Diagnose.Start();
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "DiagnoseAllStorehouse");
            }
            return message;
        }

        public async Task<string> ClearAllStorehouse()
        {
            string message;
            try
            {
                _scan.ClearAllModuls();
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "ClearAllStorehouse");
            }

            return message;
        }

        public async Task<string> ClearOneModul(int modul)
        {
            string message;
            try
            {
                _scan.ClearOneModul(modul);
                message = Respond.OK.ToString();

            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "ClearOneModul");
            }

            return message;
        }

        public async Task<string> SendSingleCell(string address, byte color1, byte color2, byte effect)
        {
            string message;
            try
            {
                message = _info.SendToCell(address, color1, color2, effect).Result;

            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "SendSingleCell");
            }

            return message;
        }

        public async Task<string> ClearSingleCell(string address)
        {
            string message;

            try
            {
                message = _info.ClearCell(address).Result;

            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "ClearSingleCell");
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
                    _info.SendToCell(element.ToString(), Convert.ToByte(color), Convert.ToByte(0), 2);
                }
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "SendListCells");
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
                    _info.ClearCell(element);
                }
                message = Respond.OK.ToString();
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "ClearListCells");
            }

            return message;
        }

        public async Task<object> SingleCellInfo(string address)
        {
            object message;
            try
            {
                message = _info.CellInfo(address);
            }
            catch (Exception ex)
            {
                message = Respond.Bad_Request + " " + ex.ToString();
                _logger.Error(ex, "SingleCellInfo");
            }
            return message.ToString();
        }

        public async Task<List<string>> CellListInfo(object addresses)
        {
            List<string> mess = new List<string>();
            List<string> result = addresses.ToString().Trim(' ').Split(',').ToList();
            try
            {
                foreach (var element in result)
                {
                    mess.Add(_info.CellInfo(element).ToString());
                }
            }
            catch (Exception ex)
            {
                mess.Add(Respond.Bad_Request + " " + ex.ToString());
                _logger.Error(ex, "CellListInfo");
            }

            return mess;
        }

        public async Task<string> CancelDiagnose()
        {
            var token = _tokenSource.Token;
            _tokenSource.Cancel();
            _settings.Cancel(token);
            return "Canceled";
        }

        public enum Respond
        {
            OK = 200,
            Bad_Request = 500,
        }

    }
}
