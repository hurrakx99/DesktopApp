Public Class Form1
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub ViewSubmissionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsToolStripMenuItem.Click
        btnViewSubmissions_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        btnCreateSubmission_Click(sender, e)
    End Sub


End Class
