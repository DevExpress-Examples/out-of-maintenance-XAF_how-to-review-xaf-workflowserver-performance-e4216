using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using DevExpress.ExpressApp.Workflow.Server;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Workflow;
using DevExpress.ExpressApp.MiddleTier;
using Solution1.Module.Win;
using DevExpress.ExpressApp.Xpo;

namespace WorkflowServerService2 {
    public partial class WorkflowServerService2 {
        private WorkflowServer server;
        public void Start() {
            server.Start();
        }
        public void Stop() {
            server.Stop();
        }
        public WorkflowServerService2() {
            //InitializeComponent();

            ServerApplication serverApplication = new ServerApplication();
            serverApplication.ApplicationName = "Solution1";
            // The service can only manage workflows for those business classes that are contained in Modules specified by the serverApplication.Modules collection.
            // So, do not forget to add the required Modules to this collection via the serverApplication.Modules.Add method.
            serverApplication.Modules.Add(new WorkflowModule());
            serverApplication.Modules.Add(new Solution1WindowsFormsModule());

            if(ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
                serverApplication.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
            serverApplication.CreateCustomObjectSpaceProvider += delegate(object sender, CreateCustomObjectSpaceProviderEventArgs e) {
                e.ObjectSpaceProvider = new XPObjectSpaceProvider(e.ConnectionString, e.Connection);
            };
            serverApplication.Setup();
            serverApplication.Logon();

            IObjectSpaceProvider objectSpaceProvider = serverApplication.ObjectSpaceProvider;

            server = new WorkflowServer("http://localhost:46232", objectSpaceProvider, objectSpaceProvider);

            server.StartWorkflowListenerService.DelayPeriod = TimeSpan.FromSeconds(15);
            server.StartWorkflowByRequestService.RequestsDetectionPeriod = TimeSpan.FromSeconds(15);
            server.RefreshWorkflowDefinitionsService.DelayPeriod = TimeSpan.FromMinutes(15);

            server.CustomizeHost += delegate(object sender, CustomizeHostEventArgs e) {
                e.WorkflowInstanceStoreBehavior.RunnableInstancesDetectionPeriod = TimeSpan.FromSeconds(15);
            };

            server.CustomHandleException += delegate(object sender, CustomHandleServiceExceptionEventArgs e) {
                Tracing.Tracer.LogError(e.Exception);
                Console.WriteLine(e.Exception.Message);
                e.Handled = false;
            };
        }
    }
}
