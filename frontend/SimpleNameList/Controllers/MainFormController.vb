Public Class MainFormController
    ' リスト
    Private _personList As List(Of Person) = New List(Of Person)()
    Public ReadOnly Property PersonList() As List(Of Person)
        Get
            Return _personList
        End Get
    End Property

    ' リストを取得してくる
    Public Async Function FetchPersonList() As Task
        _personList = Await BackendConnection.FetchList()
    End Function

    ' 新規追加
    Public Async Function AddNewPerson(lastName As String, firstName As String) As Task(Of Boolean)
        Return Await BackendConnection.AddNewPerson(lastName, firstName)
    End Function
End Class
