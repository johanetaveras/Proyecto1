Imports System.Data.SqlClient
Public Class ConsultaServiciosFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS;Initial Catalog=Proyecto1DB;Integrated Security=True ")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuFrm.Show()
    End Sub
    Sub Buscar_CODIGO()
        Dim cmd As New SqlClient.SqlCommand("Select * From servicios where codigo='" & TextBox1.Text & "'", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DR As SqlClient.SqlDataReader
        Dim ds As New DataSet
        DA.Fill(ds, "servicios")
        DataGridView1.DataSource = ds.Tables("servicios")
        cn.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then
            TextBox1.Focus()
        Else
            MsgBox("ESTE CODIGO NO EXISTE EN NUESTRO SISTEMA")
        End If
        cn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Buscar_CODIGO()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

    End Sub
End Class