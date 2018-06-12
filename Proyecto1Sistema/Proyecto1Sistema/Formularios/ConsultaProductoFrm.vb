Imports System.Data.SqlClient
Public Class ConsultaProductoFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS201;Initial Catalog=Proyecto1DB;Integrated Security=True")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuFrm.Show()
    End Sub
    Sub Buscar_CODIGO()
        Dim cmd As New SqlClient.SqlCommand("Select * From electrodomesticos where codigo='" & TextBox1.Text & "'", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DR As SqlClient.SqlDataReader
        Dim ds As New DataSet
        DA.Fill(ds, "electrodomesticos")
        DataGridView1.DataSource = ds.Tables("electrodomesticos")
        cn.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then
            TextBox1.Focus()
        Else
            MsgBox("ESTE CODIGO NO EXISTE EN NUESTRO SISTEMA")
        End If
        cn.Close()
    End Sub
    Sub Buscar_CODIGO1()
        Dim cmd As New SqlClient.SqlCommand("Select * From muebles where codigo='" & TextBox1.Text & "'", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DR As SqlClient.SqlDataReader
        Dim ds As New DataSet
        DA.Fill(ds, "muebles")
        DataGridView1.DataSource = ds.Tables("muebles")
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
        If ComboBox1.Text = "Electrodomesticos" Then
            Buscar_CODIGO()

        End If
        If ComboBox1.Text = "Muebles" Then
            Buscar_CODIGO1()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

    End Sub
End Class