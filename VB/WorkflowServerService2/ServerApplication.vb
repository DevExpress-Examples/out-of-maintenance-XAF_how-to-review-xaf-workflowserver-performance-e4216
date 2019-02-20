Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp

Namespace WorkflowServerService2
	Public Class ServerApplication
		Inherits XafApplication

		Protected Overrides Function CreateLayoutManagerCore(ByVal simple As Boolean) As DevExpress.ExpressApp.Layout.LayoutManager
			Throw New NotImplementedException()
		End Function
		Public Sub Logon()
			MyBase.Logon(Nothing)
		End Sub
	End Class
End Namespace
