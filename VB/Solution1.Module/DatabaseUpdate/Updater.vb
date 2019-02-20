Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Security
Imports Solution1.Module.BusinessObjects
Imports DevExpress.ExpressApp.Workflow.Versioning
Imports DevExpress.ExpressApp.Workflow.Xpo

Namespace Solution1.Module.DatabaseUpdate
	Public Class Updater
		Inherits ModuleUpdater

		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			ObjectSpace.Delete(ObjectSpace.GetObjects(Of Note)())
			ObjectSpace.Delete(ObjectSpace.GetObjects(Of TaskType)())
			ObjectSpace.CommitChanges()

			For i As Integer = 0 To 999
				Dim note As Note = ObjectSpace.CreateObject(Of Note)()
				note.Name = "note " & i
			Next i
			Dim taskType As TaskType = ObjectSpace.CreateObject(Of TaskType)()
			taskType.Name = "2"

			Dim wfDefinition As XpoWorkflowDefinition = ObjectSpace.FindObject(Of XpoWorkflowDefinition)(New BinaryOperator("Name", "Simple performance test"))
			If wfDefinition Is Nothing Then
				wfDefinition = ObjectSpace.CreateObject(Of XpoWorkflowDefinition)()
				wfDefinition.Name = "Simple performance test"
				wfDefinition.Criteria = "[IsProcessed] = False"
				Dim ver As Version = GetType(XafApplication).Assembly.GetName().Version
				wfDefinition.Xaml = String.Format(Xaml1, ver.Major, ver.Minor)
				wfDefinition.TargetObjectType = GetType(Note)
				wfDefinition.AutoStartWhenObjectFitsCriteria = True
				wfDefinition.AutoStartWhenObjectIsCreated = False
				wfDefinition.IsActive = True
			End If

			ObjectSpace.CommitChanges()
		End Sub
		Private Const Xaml1 As String = "<Activity mc:Ignorable=""sap"" x:Class=""DevExpress.Workflow.XafWorkflow"" xmlns=""http://schemas.microsoft.com/netfx/2009/xaml/activities"" 
xmlns:dpb=""clr-namespace:DevExpress.Persistent.BaseImpl;assembly=DevExpress.Persistent.BaseImpl.v{0}.{1}"" 
xmlns:dwa=""clr-namespace:DevExpress.Workflow.Activities;assembly=DevExpress.Workflow.Activities.v{0}.{1}"" 
xmlns:dx=""clr-namespace:DevExpress.Xpo;assembly=DevExpress.Data.v{0}.{1}"" 
xmlns:dx1=""clr-namespace:DevExpress.Xpo;assembly=DevExpress.Xpo.v{0}.{1}"" 
xmlns:dxh=""clr-namespace:DevExpress.Xpo.Helpers;assembly=DevExpress.Data.v{0}.{1}"" 
xmlns:dxh1=""clr-namespace:DevExpress.Xpo.Helpers;assembly=DevExpress.Xpo.v{0}.{1}"" 
xmlns:dxmh=""clr-namespace:DevExpress.Xpo.Metadata.Helpers;assembly=DevExpress.Xpo.v{0}.{1}"" xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006"" xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities"" xmlns:s=""clr-namespace:System;assembly=mscorlib"" xmlns:s1=""clr-namespace:System;assembly=System"" xmlns:s2=""clr-namespace:System;assembly=System.Core"" xmlns:s3=""clr-namespace:System;assembly=System.ServiceModel"" xmlns:s4=""clr-namespace:System;assembly=System.Configuration.Install"" xmlns:s5=""clr-namespace:System;assembly=System.DirectoryServices.Protocols"" xmlns:sa=""clr-namespace:System.Activities;assembly=System.Activities"" xmlns:sap=""http://schemas.microsoft.com/netfx/2009/xaml/activities/presentation"" xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib"" xmlns:smb=""clr-namespace:Solution1.Module.BusinessObjects;assembly=Solution1.Module"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
  <x:Members>
    <x:Property Name=""targetObjectId"" Type=""InArgument(x:Object)"" />
  </x:Members>
  <sap:VirtualizedContainerService.HintSize>330,867</sap:VirtualizedContainerService.HintSize>
  <mva:VisualBasic.Settings>Assembly references and imported namespaces serialized as XML namespaces</mva:VisualBasic.Settings>
  <Sequence sap:VirtualizedContainerService.HintSize=""290,827"" mva:VisualBasic.Settings=""Assembly references and imported namespaces serialized as XML namespaces"">
    <sap:WorkflowViewStateService.ViewState>
      <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
        <x:Boolean x:Key=""IsExpanded"">True</x:Boolean>
      </scg:Dictionary>
    </sap:WorkflowViewStateService.ViewState>
    <dwa:ObjectSpaceTransactionScope AutoCommit=""True"" sap:VirtualizedContainerService.HintSize=""268,703"">
      <dwa:ObjectSpaceTransactionScope.Variables>
        <Variable x:TypeArguments=""smb:Note"" Name=""note"" />
        <Variable x:TypeArguments=""smb:Task"" Name=""task"" />
        <Variable x:TypeArguments=""smb:TaskType"" Name=""taskType"" />
      </dwa:ObjectSpaceTransactionScope.Variables>
      <dwa:GetObjectByKey x:TypeArguments=""smb:Note"" sap:VirtualizedContainerService.HintSize=""242,59"" Key=""[targetObjectId]"" Result=""[note]"" />
      <Assign sap:VirtualizedContainerService.HintSize=""242,58"">
        <Assign.To>
          <OutArgument x:TypeArguments=""x:Boolean"">[note.IsProcessed]</OutArgument>
        </Assign.To>
        <Assign.Value>
          <InArgument x:TypeArguments=""x:Boolean"">True</InArgument>
        </Assign.Value>
      </Assign>
      <dwa:CreateObject x:TypeArguments=""smb:Task"" sap:VirtualizedContainerService.HintSize=""242,22"" Result=""[task]"" />
      <Assign sap:VirtualizedContainerService.HintSize=""242,58"">
        <Assign.To>
          <OutArgument x:TypeArguments=""s:DateTime"">[task.CreatedOn]</OutArgument>
        </Assign.To>
        <Assign.Value>
          <InArgument x:TypeArguments=""s:DateTime"">[DateTime.Now]</InArgument>
        </Assign.Value>
      </Assign>
      <Assign sap:VirtualizedContainerService.HintSize=""242,58"">
        <Assign.To>
          <OutArgument x:TypeArguments=""x:String"">[task.Name]</OutArgument>
        </Assign.To>
        <Assign.Value>
          <InArgument x:TypeArguments=""x:String"">[note.Name]</InArgument>
        </Assign.Value>
      </Assign>
      <Assign sap:VirtualizedContainerService.HintSize=""242,58"">
        <Assign.To>
          <OutArgument x:TypeArguments=""smb:Note"">[task.SourceNote]</OutArgument>
        </Assign.To>
        <Assign.Value>
          <InArgument x:TypeArguments=""smb:Note"">[note]</InArgument>
        </Assign.Value>
      </Assign>
      <dwa:FindObjectByCriteria x:TypeArguments=""smb:TaskType"" Criteria=""Name = '2'"" sap:VirtualizedContainerService.HintSize=""242,59"" Result=""[taskType]"" />
      <Assign sap:VirtualizedContainerService.HintSize=""242,58"">
        <Assign.To>
          <OutArgument x:TypeArguments=""smb:TaskType"">[task.TaskType]</OutArgument>
        </Assign.To>
        <Assign.Value>
          <InArgument x:TypeArguments=""smb:TaskType"">[taskType]</InArgument>
        </Assign.Value>
      </Assign>
    </dwa:ObjectSpaceTransactionScope>
  </Sequence>
</Activity>"
	End Class
End Namespace
