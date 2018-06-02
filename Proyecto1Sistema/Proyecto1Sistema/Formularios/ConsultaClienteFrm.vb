Imports System.Data.SqlClient
Public Class ConsultaClienteFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS;Initial Catalog=Proyecto1DB;Integrated Security=True ")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuFrm.Show()
    End Sub
    Sub Buscar_CODIGO()
        Dim cmd As New SqlClient.SqlCommand("Select * From clientes where codigo='" & TextBox1.Text & "'", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DR As SqlClient.SqlDataReader
        Dim ds As New DataSet
        DA.Fill(ds, "clientes")
        DataGridView1.DataSource = ds.Tables("clientes")
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Buscar_CODIGO()
        End If
    End Sub
End Class