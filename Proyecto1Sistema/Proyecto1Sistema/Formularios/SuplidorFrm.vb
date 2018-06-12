Imports System.Data.SqlClient
Public Class SuplidorFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS201;Initial Catalog=Proyecto1DB;Integrated Security=True")
    Sub Nuevo1()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
    End Sub
    Private Sub SuplidorFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Nuevo1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Public Sub ent1()
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO suplidores(nombre_empresa,direccion,telefono,email,productos,modelo,caracteristicas,contacto1,contacto2,precio_unid_compra,precio_unid_venta)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "')", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Or (TextBox6.Text = "") Or (TextBox7.Text = "") Or (TextBox8.Text = "") Or (TextBox9.Text = "") Or (TextBox10.Text = "") Or (TextBox11.Text = "") Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS PARA REGISTRAR")
        Else
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("REGISTRO GUARDADO")
            TextBox1.Focus()
            Nuevo1()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ent1()

    End Sub
    Public Sub ent(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub SuplidorFrm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox10.KeyPress, TextBox1.KeyPress, MyBase.KeyPress
        ent(sender, e)
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If e.KeyChar = Chr(13) Then
            ent1()

        End If
    End Sub
End Class