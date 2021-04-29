using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace ISStorehouseService
{
    [ServiceContract(Namespace = "ISStorehouseService")]
    public interface IStorehouseService
    {
        [OperationContract]
        [WebGet]
        Task<string> DiagnoseAllStorehouse();

        [OperationContract]
        [WebGet]
        Task<string> DiagnoseOneModul(short modul);

        [OperationContract]
        [WebGet]
        Task<string> ClearAllStorehouse();

        [OperationContract]
        [WebGet]
        Task<string> ClearOneModul(int modul);

        [OperationContract]
        [WebGet]
        Task<string> SendSingleCell(string address, byte color1, byte color2, byte effect);

        [OperationContract]
        [WebGet]
        Task<string> SendListCells(object addresses);

        [OperationContract]
        [WebGet]
        Task<string> ClearSingleCell(string address);

        [OperationContract]
        [WebGet]
        Task<string> ClearListCells(object addresses);

        [OperationContract]
        [WebGet]
        Task<object> SingleCellInfo(string address);

        [OperationContract]
        [WebGet]
        Task<List<string>> CellListInfo(object addresses);
        
        [OperationContract]
        [WebGet]
        Task<string> CancelDiagnose();

    }
}
