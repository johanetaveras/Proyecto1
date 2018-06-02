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

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        UsuariosFrm.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        ClienteFrm.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        EmpleadosFrm.Show()
    End Sub

    Private Sub SuplidorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SuplidorToolStripMenuItem2.Click
        SuplidorFrm.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem2.Click
        ServiciosFrm.Show()
    End Sub

    Private Sub MueblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MueblesToolStripMenuItem.Click
        MueblesFrm.Show()
    End Sub

    Private Sub ElectrodomesticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElectrodomesticosToolStripMenuItem.Click
        electrodoFrm.Show()
    End Sub
End Class