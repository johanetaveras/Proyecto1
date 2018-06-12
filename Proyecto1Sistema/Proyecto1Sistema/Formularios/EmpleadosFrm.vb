Imports System.Data.SqlClient
Imports System.IO



Public Class EmpleadosFrm
    Dim cn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS201;Initial Catalog=Proyecto1DB;Integrated Security=True ")
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
        TextBox15.Clear()
        TextBox14.Clear()
        TextBox13.Clear()
        TextBox12.Clear()
        TextBox11.Clear()
        TextBox10.Clear()
        PictureBox1.Image = Nothing
        TextBox9.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Nuevo1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO empleado(nombres,apellidos,direccion,telefono,celular,email,apodo,imagen_cedula,cedula,departemento_area,cargo,salario,fecha_nombramiento,fecha_cancelado,pensionado)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "',(@img),'" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "')", cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim ms As New MemoryStream

        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        cmd.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Or (TextBox6.Text = "") Or (TextBox7.Text = "") Or (TextBox9.Text = "") Or (TextBox10.Text = "") Or (TextBox11.Text = "") Or (TextBox12.Text = "") Or (TextBox13.Text = "") Or (TextBox14.Text = "") Or (TextBox15.Text = "") Then
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Elegir imagen(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class