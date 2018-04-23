Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.Security
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp

Namespace WorkflowServerService2
	Public Class WorkflowServerAuthentication
		Inherits AuthenticationBase
		Private workflowWorkerUserCriteria As CriteriaOperator
		Public Sub New(ByVal workflowWorkerUserCriteria As CriteriaOperator)
			Me.workflowWorkerUserCriteria = workflowWorkerUserCriteria
		End Sub
		Public Overrides Overloads Function Authenticate(ByVal objectSpace As IObjectSpace) As Object
			Dim user As Object = objectSpace.FindObject(UserType, workflowWorkerUserCriteria)
			If user Is Nothing Then
				Throw New AuthenticationException("", "Cannot find workflow worker user.")
			End If
			Return user
		End Function
		Private privateUserType As Type
		Public Overrides Property UserType() As Type
			Get
				Return privateUserType
			End Get
			Set(ByVal value As Type)
				privateUserType = value
			End Set
		End Property
		Public Overrides ReadOnly Property AskLogonParametersViaUI() As Boolean
			Get
				Return False
			End Get
		End Property
		Public Overrides ReadOnly Property IsLogoffEnabled() As Boolean
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace
