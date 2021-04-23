using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
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
        Task<string> SendListCells(string address);

        [OperationContract]
        [WebGet]
        Task<string> ClearSingleCell(string address);

        [OperationContract]
        [WebGet]
        Task<string> ClearListCells();

        [OperationContract]
        [WebGet]
        Task<string> SingleCellInfo(string address);

        [OperationContract]
        [WebGet]
        Task<string> CellListInfo();

    }
}
