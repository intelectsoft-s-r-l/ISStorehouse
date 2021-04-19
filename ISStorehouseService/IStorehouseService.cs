using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ISStorehouseService
{
    [ServiceContract]
    public interface IStorehouseService
    {
        [OperationContract]
        [WebGet]
        Task DiagnoseAllStorehouse();

        [OperationContract]
        [WebGet]
        Task DiagnoseOneModul(int modul);

        [OperationContract]
        [WebGet]
        Task ClearAllStorehouse();

        [OperationContract]
        [WebGet]
        Task ClearOneModul(int modul);

        [OperationContract]
        [WebGet]
        Task SendSingleCell(string address, byte color1, byte color2, byte effect);

        [OperationContract]
        [WebGet]
        Task SendListCells();

        [OperationContract]
        [WebGet]
        Task SingleCellInfo();

        [OperationContract]
        [WebGet]
        Task CellListInfo();

    }
}
