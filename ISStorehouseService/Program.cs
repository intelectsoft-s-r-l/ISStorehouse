using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ISStorehouseService
{
    public partial class Program : ServiceBase
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SHService()
            };
            ServiceBase.Run(ServicesToRun);
        }

        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ServiceName = "StorehouseService";
        }
    }
}
