Public Class MainFormController
    ' リスト
    Private _personList As List(Of Person) = New List(Of Person)()
    Public ReadOnly Property PersonList() As List(Of Person)
        Get
            Return _personList
        End Get
    End Property

    ' リストを取得してくる
    Public Sub FetchPersonList()
    End Sub
End Class
