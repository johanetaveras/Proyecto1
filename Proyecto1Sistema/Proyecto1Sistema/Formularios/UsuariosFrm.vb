Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class UsuariosFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS201;Initial Catalog=Proyecto1DB;Integrated Security=True")
    Sub Nuevo()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub UsuariosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub
    Public Sub ent1()
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO TBL_USUARIO(USUARIO,Clave,departamento_area)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ent1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nuevo()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Public Sub ent(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub UsuariosFrm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress, MyBase.KeyPress
        ent(sender, e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            ent1()
        End If
    End Sub
End Class