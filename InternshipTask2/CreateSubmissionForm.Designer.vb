<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        txtGitHub = New TextBox()
        Label4 = New Label()
        txtPhoneNumber = New TextBox()
        Label3 = New Label()
        TxtEmail = New TextBox()
        Label2 = New Label()
        txtName = New TextBox()
        Label1 = New Label()
        btnStartStop = New Button()
        btnSubmit = New Button()
        lblStopwatch = New Label()
        SuspendLayout()
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(363, 228)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(100, 23)
        txtGitHub.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(258, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 15)
        Label4.TabIndex = 14
        Label4.Text = "GitHub Link:"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(363, 176)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(100, 23)
        txtPhoneNumber.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(258, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 12
        Label3.Text = "Phone number:"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(363, 129)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(100, 23)
        TxtEmail.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(258, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 10
        Label2.Text = "Email:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(363, 83)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(258, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 8
        Label1.Text = "Name:"
        ' 
        ' btnStartStop
        ' 
        btnStartStop.BackColor = Color.Yellow
        btnStartStop.FlatStyle = FlatStyle.Flat
        btnStartStop.Location = New Point(190, 289)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(181, 59)
        btnStartStop.TabIndex = 16
        btnStartStop.Text = "Toggle Stopwatch (CTRL + T)"
        btnStartStop.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DodgerBlue
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Location = New Point(312, 379)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(181, 59)
        btnSubmit.TabIndex = 17
        btnSubmit.Text = "Submit (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblStopwatch.Location = New Point(441, 306)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(70, 21)
        lblStopwatch.TabIndex = 18
        lblStopwatch.Text = "00:00:00"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStop)
        Controls.Add(txtGitHub)
        Controls.Add(Label4)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label3)
        Controls.Add(TxtEmail)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatch As Label
End Class
