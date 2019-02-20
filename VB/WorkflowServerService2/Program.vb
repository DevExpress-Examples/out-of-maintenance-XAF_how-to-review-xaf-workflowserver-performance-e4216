Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ServiceProcess
Imports System.Text

Namespace WorkflowServerService2
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Sub Main()
			Console.WriteLine("Starting...")
			Dim service As New WorkflowServerService2()
			service.Start()
			Console.WriteLine("Started. Press Enter to stop.")
			Console.ReadLine()
			Console.WriteLine("Stopping...")
			service.Stop()
			Console.WriteLine("Stopped.")
		End Sub
	End Module
End Namespace
