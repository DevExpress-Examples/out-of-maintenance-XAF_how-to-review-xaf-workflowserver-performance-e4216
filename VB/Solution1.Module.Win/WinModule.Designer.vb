Namespace Solution1.Module.Win
	Partial Public Class Solution1WindowsFormsModule
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
			' 
			' Solution1WindowsFormsModule
			' 
			Me.RequiredModuleTypes.Add(GetType(Solution1.Module.Solution1Module))
			Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule))
			Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule))

		End Sub

		#End Region
	End Class
End Namespace
