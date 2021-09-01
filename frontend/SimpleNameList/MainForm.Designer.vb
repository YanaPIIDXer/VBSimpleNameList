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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.personListBox)
        Me.Name = "MainForm"
        Me.Text = "名簿システム"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents personListBox As ListBox
End Class
