Public Class MainForm
    ' コントローラー
    Private _controller As MainFormController = New MainFormController()

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAddButtonEnable()
        Await FetchAndUpdatePersonList()
    End Sub

    ' リストを取ってきて更新する
    Private Async Function FetchAndUpdatePersonList() As Task
        Await _controller.FetchPersonList()
        personListBox.DataSource = _controller.PersonList
    End Function

    Private Sub lastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles lastNameTextBox.TextChanged
        UpdateAddButtonEnable()
    End Sub

    Private Sub firstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles firstNameTextBox.TextChanged
        UpdateAddButtonEnable()
    End Sub

    ' addButtonの活性化状態更新
    Private Sub UpdateAddButtonEnable()
        addButton.Enabled = lastNameTextBox.Text.Length > 0 And firstNameTextBox.Text.Length > 0
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

    End Sub
End Class
