Imports System.Data.SqlClient
Public Class ServiciosFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS201;Initial Catalog=Proyecto1DB;Integrated Security=True")
    Sub Nuevo()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO servicios(nombre_serv,descripcion,contactos,precio)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS PARA REGISTRAR")
        Else
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("REGISTRO GUARDADO")
            TextBox1.Focus()
            Nuevo()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Nuevo()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Public Sub ent(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Button2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress, Button2.KeyPress
        ent(sender, e)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO servicios(nombre_serv,descripcion,contactos,precio)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", cn)
            Dim DA As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
                MsgBox("DEBE LLENAR TODOS LOS CAMPOS PARA REGISTRAR")
            Else
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("REGISTRO GUARDADO")
                TextBox1.Focus()
                Nuevo()

            End If
        End If
    End Sub

    Private Sub ServiciosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class