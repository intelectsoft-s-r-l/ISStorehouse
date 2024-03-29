﻿using ISStorehouseDLL.Common;
using System;
using System.Configuration;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Threading;

namespace ISStorehouseService
{
    public partial class SHService : ServiceBase
    {
        Settings Settings = new Settings();
        public SHService()
        {
            InitializeComponent();
            stopping = false;
            stoppedEvent = new ManualResetEvent(false);
        }



        public void StartService()
        {
            EventLog.WriteEntry("IS Storehouse service OnStart");
            ThreadPool.QueueUserWorkItem(new WaitCallback(SHServiceWorker));
        }

        protected override void OnStart(string[] args)
        {
            StartService();
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("IS Storehouse service OnStop");
            stopping = true;
            stoppedEvent.WaitOne();
        }

        private bool stopping;
        private ManualResetEvent stoppedEvent;
        private static AppSettingsReader read = new AppSettingsReader();
        private static bool UpdatedDatabase = false;
        private ServiceHost ISStorehouseHost;

        internal static string MetaUri
        {
            get
            {
                return Convert.ToString(read.GetValue("MetaUri", typeof(string)));
            }
        }

        internal static string Port
        {
            get
            {
                return Convert.ToString(read.GetValue("Port", typeof(string)));
            }
        }

        private void SHServiceWorker(object state)
        {
            SHServiceStart();
            Settings.CheckDataBase();
            ///
            //SHServiceStart();
            //while (!stopping)
            //    Thread.Sleep(5000);
            //stoppedEvent.Set();

        }

        private void SHServiceStart()
        {
            try
            {
                StorehouseService storehouse = new StorehouseService();

                string ipHost = "localhost";
                string ipPort = "8000";

                if (ipPort != "0")
                {
                    string servicename = "ISStorehouseService";
                    string uriS = "http://{0}:{1}/" + servicename;

                    uriS = string.Format(uriS, ipHost, ipPort);
                    ISStorehouseHost = new ServiceHost(storehouse, new Uri(uriS));

                    WebHttpBinding httpExportBinding = new WebHttpBinding();

                    httpExportBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                    httpExportBinding.Security.Transport.Realm = "";
                    WebHttpBehavior beh = new WebHttpBehavior();
                    beh.DefaultOutgoingResponseFormat = System.ServiceModel.Web.WebMessageFormat.Xml;
                    beh.DefaultBodyStyle = System.ServiceModel.Web.WebMessageBodyStyle.Wrapped;
                    beh.HelpEnabled = true;

                    var withBlock = ISStorehouseHost.AddServiceEndpoint(typeof(IStorehouseService), httpExportBinding, "xml");
                    withBlock.Behaviors.Add(beh);

                    var httpExportBindingJ = new WebHttpBinding();

                    httpExportBindingJ.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                    httpExportBindingJ.Security.Transport.Realm = "";
                    var behJ = new WebHttpBehavior();
                    behJ.DefaultBodyStyle = System.ServiceModel.Web.WebMessageBodyStyle.Wrapped;
                    behJ.DefaultOutgoingResponseFormat = System.ServiceModel.Web.WebMessageFormat.Json;
                    behJ.HelpEnabled = true;
                    {
                        var withBlock1 = ISStorehouseHost.AddServiceEndpoint(typeof(ISStorehouseService.IStorehouseService), httpExportBindingJ, "json");
                        withBlock1.Behaviors.Add(behJ);
                    }

                    ServiceMetadataBehavior metaBehavior = new ServiceMetadataBehavior();

                    ISStorehouseHost.Description.Behaviors.Add(metaBehavior);
                    WSHttpBinding metaBinging = new WSHttpBinding();

                    metaBinging.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                    metaBinging.Security.Transport.Realm = "";
                    ISStorehouseHost.AddServiceEndpoint(typeof(IMetadataExchange), metaBinging, "mex");

                    BasicHttpBinding basicHttpBnd = new BasicHttpBinding();

                    basicHttpBnd.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                    basicHttpBnd.Security.Transport.Realm = "";

                    var withBlock2 = ISStorehouseHost.AddServiceEndpoint(typeof(IStorehouseService), basicHttpBnd, "soap");
                    ISStorehouseHost.Open();
                    EventLog.WriteEntry(uriS.ToString());
                }
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.ToString());
            }
        }

    }
}
