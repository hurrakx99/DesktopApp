Imports InternshipTask2.ViewSubmissionsForm

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatch As New Stopwatch()
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatchRunning Then
            stopwatch.Stop()
            btnStartStop.Text = "Start Stopwatch"
        Else
            stopwatch.Start()
            btnStartStop.Text = "Stop Stopwatch"
        End If
        stopwatchRunning = Not stopwatchRunning
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission(txtName.Text, TxtEmail.Text, txtPhoneNumber.Text, txtGitHub.Text, lblStopwatch.Text)
        MessageBox.Show("Submission successful!")
        Me.Close()
    End Sub
End Class