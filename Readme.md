<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128592690/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4216)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DomainObject1.cs](./CS/Solution1.Module/BusinessObjects/DomainObject1.cs) (VB: [DomainObject1.vb](./VB/Solution1.Module/BusinessObjects/DomainObject1.vb))
* [Updater.cs](./CS/Solution1.Module/DatabaseUpdate/Updater.cs) (VB: [Updater.vb](./VB/Solution1.Module/DatabaseUpdate/Updater.vb))
* [Program.cs](./CS/WorkflowServerService2/Program.cs) (VB: [Program.vb](./VB/WorkflowServerService2/Program.vb))
* [WorkflowServerService.cs](./CS/WorkflowServerService2/WorkflowServerService.cs) (VB: [WorkflowServerService.vb](./VB/WorkflowServerService2/WorkflowServerService.vb))
<!-- default file list end -->
# How to review XAF WorkflowServer performance?


<p>This example demonstrates a simple approach to review performance of WindowsWorkflowFoundation in conjunction with XAF WorkflowServer and XAF database related activities.</p><p>This example creates 1000 'Note' objects and a single workflow definition object that processes each 'Note' object and creates a new 'Task' object.</p><p>Compile the solution and start the 'Solution1.Win' project to create a database with initial data. Then, start the 'WorkflowServerConsoleApp' project to process the created 'Note' objects.</p><p>Note that you need to start VisualStudio in the 'Run as administrator' mode because of the WCF specificities, described in the  <a href="http://msdn.microsoft.com/en-us/library/ms734712.aspx"><u>WCF - Getting Started Tutorial</u></a></p>

<br/>


