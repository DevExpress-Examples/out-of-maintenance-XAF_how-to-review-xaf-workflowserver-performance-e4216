Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace Solution1.Module.BusinessObjects
	<DefaultClassOptions> _
	Public Class Note
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here or place it only when the IsLoading property is false:
			' if (!IsLoading){
			'    It is now OK to place your initialization code here.
			' }
			' or as an alternative, move your initialization code into the AfterConstruction method.
		End Sub
		Public Property Name() As String
			Get
				Return GetPropertyValue(Of String)("Name")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", value)
			End Set
		End Property
		Public Property IsProcessed() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("IsProcessed")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("IsProcessed", value)
			End Set
		End Property
	End Class

	<DefaultClassOptions> _
	Public Class Task
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here or place it only when the IsLoading property is false:
			' if (!IsLoading){
			'    It is now OK to place your initialization code here.
			' }
			' or as an alternative, move your initialization code into the AfterConstruction method.
		End Sub
		Public Property CreatedOn() As DateTime
			Get
				Return GetPropertyValue(Of DateTime)("CreatedOn")
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue(Of DateTime)("CreatedOn", value)
			End Set
		End Property
		Public Property Name() As String
			Get
				Return GetPropertyValue(Of String)("Name")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", value)
			End Set
		End Property
		Public Property SourceNote() As Note
			Get
				Return GetPropertyValue(Of Note)("SourceNote")
			End Get
			Set(ByVal value As Note)
				SetPropertyValue(Of Note)("SourceNote", value)
			End Set
		End Property
		Public Property TaskType() As TaskType
			Get
				Return GetPropertyValue(Of TaskType)("TaskType")
			End Get
			Set(ByVal value As TaskType)
				SetPropertyValue(Of TaskType)("TaskType", value)
			End Set
		End Property
	End Class

	<DefaultClassOptions> _
	Public Class TaskType
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Property Name() As String
			Get
				Return GetPropertyValue(Of String)("Name")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", value)
			End Set
		End Property
	End Class
End Namespace
