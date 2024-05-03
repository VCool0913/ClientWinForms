Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub updatelog2()
        MainForm.Hide()
        MainForm.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MainForm.Show()
        MainForm.Visible = True
        Me.Close()
    End Sub
End Class