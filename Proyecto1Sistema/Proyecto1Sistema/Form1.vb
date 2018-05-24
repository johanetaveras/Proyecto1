Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Dim N As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        N = N + 1
        ProgressBar1.Value = N
        Label1.Text = N.ToString
        If N = 100 Then
            Timer1.Stop()
            Me.Hide()
            LoginFrm.Show()
        End If
    End Sub
End Class
