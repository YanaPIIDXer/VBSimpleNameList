Public Class MainForm
    ' コントローラー
    Private _controller As MainFormController = New MainFormController()

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await FetchAndUpdatePersonList()
    End Sub

    ' リストを取ってきて更新する
    Private Async Function FetchAndUpdatePersonList() As Task
        Await _controller.FetchPersonList()
        personListBox.DataSource = _controller.PersonList
    End Function
End Class
