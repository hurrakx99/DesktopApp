<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        txtName = New TextBox()
        TxtEmail = New TextBox()
        Label2 = New Label()
        txtPhoneNumber = New TextBox()
        Label3 = New Label()
        txtGitHub = New TextBox()
        Label4 = New Label()
        txtStopwatch = New TextBox()
        Label5 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(202, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(307, 112)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 1
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(307, 158)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.ReadOnly = True
        TxtEmail.Size = New Size(100, 23)
        TxtEmail.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email:"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(307, 205)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(100, 23)
        txtPhoneNumber.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(202, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 4
        Label3.Text = "Phone number:"
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(307, 257)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.ReadOnly = True
        txtGitHub.Size = New Size(100, 23)
        txtGitHub.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(202, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 15)
        Label4.TabIndex = 6
        Label4.Text = "GitHub Link:"
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(307, 311)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(100, 23)
        txtStopwatch.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(202, 311)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 8
        Label5.Text = "Stopwatch Time:"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Location = New Point(202, 370)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(125, 38)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "Previous (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.DodgerBlue
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Location = New Point(360, 370)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(144, 38)
        btnNext.TabIndex = 11
        btnNext.Text = "Next (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(Label5)
        Controls.Add(txtGitHub)
        Controls.Add(Label4)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label3)
        Controls.Add(TxtEmail)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "Saiprasad Patil, Slidely Task 2-Slidely Form App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
