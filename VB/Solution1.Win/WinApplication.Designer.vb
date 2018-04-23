Imports Microsoft.VisualBasic
Imports System
Namespace Solution1.Win
	Partial Public Class Solution1WindowsFormsApplication
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
			Me.module3 = New Solution1.Module.Solution1Module()
			Me.module4 = New Solution1.Module.Win.Solution1WindowsFormsModule()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			Me.workflowWindowsFormsModule1 = New DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule()
			Me.conditionalAppearanceModule1 = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
			Me.workflowModule1 = New DevExpress.ExpressApp.Workflow.WorkflowModule()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=S" & "olution1"
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
			' 
			' workflowModule1
			' 
			Me.workflowModule1.RunningWorkflowInstanceInfoType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoRunningWorkflowInstanceInfo)
			Me.workflowModule1.StartWorkflowRequestType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoStartWorkflowRequest)
			Me.workflowModule1.UserActivityVersionType = GetType(DevExpress.ExpressApp.Workflow.Versioning.XpoUserActivityVersion)
			Me.workflowModule1.WorkflowControlCommandRequestType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoWorkflowInstanceControlCommandRequest)
			Me.workflowModule1.WorkflowDefinitionType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoWorkflowDefinition)
			Me.workflowModule1.WorkflowInstanceKeyType = GetType(DevExpress.Workflow.Xpo.XpoInstanceKey)
			Me.workflowModule1.WorkflowInstanceType = GetType(DevExpress.Workflow.Xpo.XpoWorkflowInstance)
			' 
			' Solution1WindowsFormsApplication
			' 
			Me.ApplicationName = "Solution1"
			Me.Connection = Me.sqlConnection1
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)
			Me.Modules.Add(Me.conditionalAppearanceModule1)
			Me.Modules.Add(Me.workflowModule1)
			Me.Modules.Add(Me.workflowWindowsFormsModule1)
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.Solution1WindowsFormsApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private module3 As Solution1.Module.Solution1Module
		Private module4 As Solution1.Module.Win.Solution1WindowsFormsModule
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
		Private workflowWindowsFormsModule1 As DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule
		Private conditionalAppearanceModule1 As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
		Private workflowModule1 As DevExpress.ExpressApp.Workflow.WorkflowModule
	End Class
End Namespace
