Public Class ViewSubmissionsForm
    Private submissions As New List(Of Submission)
    Private currentIndex As Integer = 0
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submissions.Add(New Submission("Saiprasad Patil", "saiprasadpatil1999@gmail.com", "8105529983", "https://github.com/hurrakx99/DesktopApp", "00:01:19"))

        ShowSubmission()
    End Sub

    Private Sub ShowSubmission()
        If submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submission = submissions(currentIndex)
            txtName.Text = submission.Name
            TxtEmail.Text = submission.Email
            txtPhoneNumber.Text = submission.Phone
            txtGitHub.Text = submission.GitHub
            txtStopwatch.Text = submission.Time
        End If
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHub As String
        Public Property Time As String

        Public Sub New(name As String, email As String, phone As String, gitHub As String, time As String)
            Me.Name = name
            Me.Email = email
            Me.Phone = phone
            Me.GitHub = gitHub
            Me.Time = time
        End Sub
    End Class
End Class
