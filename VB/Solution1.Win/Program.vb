Imports System
Imports System.Configuration
Imports System.Windows.Forms

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace Solution1.Win
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
#If EASYTEST Then
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register()
#End If

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
			Dim winApplication As New Solution1WindowsFormsApplication()
#If EASYTEST Then
			If ConfigurationManager.ConnectionStrings("EasyTestConnectionString") IsNot Nothing Then
				winApplication.ConnectionString = ConfigurationManager.ConnectionStrings("EasyTestConnectionString").ConnectionString
			End If
#End If
			If ConfigurationManager.ConnectionStrings("ConnectionString") IsNot Nothing Then
				winApplication.ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
			End If
			Try
				' Uncomment this line when using the Middle Tier application server:
				' new DevExpress.ExpressApp.MiddleTier.MiddleTierClientApplicationConfigurator(winApplication);
				winApplication.Setup()
				winApplication.Start()
			Catch e As Exception
				winApplication.HandleException(e)
			End Try
		End Sub
	End Module
End Namespace
