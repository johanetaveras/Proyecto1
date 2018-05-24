Public Class MenuFrm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Hide()
        ConsultaUsuariosFrm.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Hide()
        ConsultaClienteFrm.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Me.Hide()
        ConsultaEmpleadosFrm.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem2.Click
        Me.Hide()
        ConsultaProductoFrm.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem1.Click
        Me.Hide()
        ConsultaServiciosFrm.Show()
    End Sub

    Private Sub SuplidorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SuplidorToolStripMenuItem1.Click
        Me.Hide()
        ConsultasSuplidorFrm.Show()
    End Sub
End Class