Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.Linq


Namespace WorkflowServerService2
	<RunInstaller(True)> _
	Partial Public Class ProjectInstaller
		Inherits System.Configuration.Install.Installer
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
