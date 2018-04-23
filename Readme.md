# How to review XAF WorkflowServer performance?


<p>This example demonstrates a simple approach to review performance of WindowsWorkflowFoundation in conjunction with XAF WorkflowServer and XAF database related activities.</p><p>This example creates 1000 'Note' objects and a single workflow definition object that processes each 'Note' object and creates a new 'Task' object.</p><p>Compile the solution and start the 'Solution1.Win' project to create a database with initial data. Then, start the 'WorkflowServerConsoleApp' project to process the created 'Note' objects.</p><p>Note that you need to start VisualStudio in the 'Run as administrator' mode because of the WCF specificities, described in the  <a href="http://msdn.microsoft.com/en-us/library/ms734712.aspx"><u>WCF - Getting Started Tutorial</u></a></p>

<br/>


