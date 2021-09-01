<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.personListBox = New System.Windows.Forms.ListBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.personPanel = New System.Windows.Forms.Panel()
        Me.patchLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.patchFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.patchButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.personPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'personListBox
        '
        Me.personListBox.FormattingEnabled = True
        Me.personListBox.ItemHeight = 15
        Me.personListBox.Location = New System.Drawing.Point(45, 13)
        Me.personListBox.Name = "personListBox"
        Me.personListBox.Size = New System.Drawing.Size(658, 379)
        Me.personListBox.TabIndex = 0
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(196, 415)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.lastNameTextBox.TabIndex = 1
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(374, 415)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.firstNameTextBox.TabIndex = 2
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(549, 415)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 3
        Me.addButton.Text = "追加"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'personPanel
        '
        Me.personPanel.Controls.Add(Me.deleteButton)
        Me.personPanel.Controls.Add(Me.patchButton)
        Me.personPanel.Controls.Add(Me.patchFirstNameTextBox)
        Me.personPanel.Controls.Add(Me.patchLastNameTextBox)
        Me.personPanel.Enabled = False
        Me.personPanel.Location = New System.Drawing.Point(754, 13)
        Me.personPanel.Name = "personPanel"
        Me.personPanel.Size = New System.Drawing.Size(253, 379)
        Me.personPanel.TabIndex = 4
        '
        'patchLastNameTextBox
        '
        Me.patchLastNameTextBox.Location = New System.Drawing.Point(67, 63)
        Me.patchLastNameTextBox.Name = "patchLastNameTextBox"
        Me.patchLastNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.patchLastNameTextBox.TabIndex = 0
        '
        'patchFirstNameTextBox
        '
        Me.patchFirstNameTextBox.Location = New System.Drawing.Point(67, 130)
        Me.patchFirstNameTextBox.Name = "patchFirstNameTextBox"
        Me.patchFirstNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.patchFirstNameTextBox.TabIndex = 1
        '
        'patchButton
        '
        Me.patchButton.Location = New System.Drawing.Point(67, 203)
        Me.patchButton.Name = "patchButton"
        Me.patchButton.Size = New System.Drawing.Size(100, 23)
        Me.patchButton.TabIndex = 2
        Me.patchButton.Text = "更新"
        Me.patchButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(67, 285)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(100, 23)
        Me.deleteButton.TabIndex = 3
        Me.deleteButton.Text = "消去"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 450)
        Me.Controls.Add(Me.personPanel)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.personListBox)
        Me.Name = "MainForm"
        Me.Text = "名簿システム"
        Me.personPanel.ResumeLayout(False)
        Me.personPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents personListBox As ListBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents personPanel As Panel
    Friend WithEvents patchLastNameTextBox As TextBox
    Friend WithEvents patchFirstNameTextBox As TextBox
    Friend WithEvents deleteButton As Button
    Friend WithEvents patchButton As Button
End Class
