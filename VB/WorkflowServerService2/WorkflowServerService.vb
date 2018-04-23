Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Linq
Imports System.ServiceProcess
Imports System.Text
Imports DevExpress.ExpressApp.Workflow.Server
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Workflow
Imports DevExpress.ExpressApp.MiddleTier
Imports Solution1.Module.Win
Imports DevExpress.ExpressApp.Xpo

Namespace WorkflowServerService2
	Partial Public Class WorkflowServerService2
		Private server As WorkflowServer
		Public Sub Start()
			server.Start()
		End Sub
		Public Sub [Stop]()
			server.Stop()
		End Sub
		Public Sub New()
			'InitializeComponent();

			Dim serverApplication As New ServerApplication()
			serverApplication.ApplicationName = "Solution1"
			' The service can only manage workflows for those business classes that are contained in Modules specified by the serverApplication.Modules collection.
			' So, do not forget to add the required Modules to this collection via the serverApplication.Modules.Add method.
			serverApplication.Modules.Add(New WorkflowModule())
			serverApplication.Modules.Add(New Solution1WindowsFormsModule())

			If ConfigurationManager.ConnectionStrings("ConnectionString") IsNot Nothing Then
				serverApplication.ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
			End If
			AddHandler serverApplication.CreateCustomObjectSpaceProvider, Function(sender, e) AnonymousMethod1(sender, e)
			serverApplication.Setup()
			serverApplication.Logon()

			Dim objectSpaceProvider As IObjectSpaceProvider = serverApplication.ObjectSpaceProvider

			server = New WorkflowServer("http://localhost:46232", objectSpaceProvider, objectSpaceProvider)

			server.StartWorkflowListenerService.DelayPeriod = TimeSpan.FromSeconds(15)
			server.StartWorkflowByRequestService.RequestsDetectionPeriod = TimeSpan.FromSeconds(15)
			server.RefreshWorkflowDefinitionsService.DelayPeriod = TimeSpan.FromMinutes(15)

			AddHandler server.CustomizeHost, Function(sender, e) AnonymousMethod2(sender, e)

			AddHandler server.CustomHandleException, Function(sender, e) AnonymousMethod3(sender, e)
		End Sub
		
		Private Function AnonymousMethod1(ByVal sender As Object, ByVal e As CreateCustomObjectSpaceProviderEventArgs) As Boolean
			e.ObjectSpaceProvider = New XPObjectSpaceProvider(e.ConnectionString, e.Connection)
			Return True
		End Function
		
		Private Function AnonymousMethod2(ByVal sender As Object, ByVal e As CustomizeHostEventArgs) As Boolean
			e.WorkflowInstanceStoreBehavior.RunnableInstancesDetectionPeriod = TimeSpan.FromSeconds(15)
			Return True
		End Function
		
		Private Function AnonymousMethod3(ByVal sender As Object, ByVal e As CustomHandleServiceExceptionEventArgs) As Boolean
			Tracing.Tracer.LogError(e.Exception)
			Console.WriteLine(e.Exception.Message)
			e.Handled = False
			Return True
		End Function
	End Class
End Namespace
