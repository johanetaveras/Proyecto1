Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class ClienteFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS;Initial Catalog=Proyecto1DB;Integrated Security=True ")
    Sub Nuevo1()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
    Sub Nuevo2()
        TextBox14.Clear()
        TextBox13.Clear()
        TextBox12.Clear()
        TextBox11.Clear()
        TextBox10.Clear()
        TextBox9.Clear()
        TextBox8.Clear()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Nuevo1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        TabPage2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        TabPage1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO clientes(nombres,apellidos,direccion,telefono,celular,cedula,trabajo,garante_id,garante_nombres,garante_apellidos,garante_cedula,garante_lugartrabajo,garante_cargo,garante_salario)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "')", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Or (TextBox6.Text = "") Or (TextBox7.Text = "") Or (TextBox8.Text = "") Or (TextBox9.Text = "") Or (TextBox10.Text = "") Or (TextBox11.Text = "") Or (TextBox12.Text = "") Or (TextBox13.Text = "") Or (TextBox14.Text = "") Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS PARA REGISTRAR")
        Else
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("REGISTRO GUARDADO")
            TextBox1.Focus()
            Nuevo1()
            Nuevo2()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nuevo2()

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
    Private Sub TabControl1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress
        ent(sender, e)
    End Sub

    Private Sub TabControl1_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress, TabControl1.KeyPress
        ent(sender, e)
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO clientes(nombres,apellidos,direccion,telefono,celular,cedula,trabajo,garante_id,garante_nombres,garante_apellidos,garante_cedula,garante_lugartrabajo,garante_cargo,garante_salario)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "')", cn)
            Dim DA As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Or (TextBox6.Text = "") Or (TextBox7.Text = "") Or (TextBox8.Text = "") Or (TextBox9.Text = "") Or (TextBox10.Text = "") Or (TextBox11.Text = "") Or (TextBox12.Text = "") Or (TextBox13.Text = "") Or (TextBox14.Text = "") Then
                MsgBox("DEBE LLENAR TODOS LOS CAMPOS PARA REGISTRAR")
            Else
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("REGISTRO GUARDADO")
                TextBox1.Focus()
                Nuevo1()
                Nuevo2()
            End If
        End If
    End Sub
End Class