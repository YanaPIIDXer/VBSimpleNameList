Public Class MainForm
    Private _controller As MainFormController = New MainFormController()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _controller.FetchPersonList()
    End Sub
End Class
