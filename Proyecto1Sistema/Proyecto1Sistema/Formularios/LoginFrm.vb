Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class LoginFrm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS;Initial Catalog=Proyecto1DB;Integrated Security=True")
        Dim dr As SqlDataReader
        Dim ds As New DataSet


        Try
            conn.Open()
            Dim cmd As New SqlCommand("Select * from TBL_USUARIO where USUARIO='" & Me.TextBox1.Text & "'" & " and Clave='" & Me.TextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader
            If (dr.HasRows = True) Then
                MessageBox.Show("Bienvenido a Nuestro Sistema")
                Me.Hide()
                MenuFrm.Show()

            ElseIf (dr.HasRows = False) Then
                MessageBox.Show("Nombre de usuario o clave incorrecta")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
            End If
        Catch Exoledb As Exception
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim conn As New SqlClient.SqlConnection("Data Source=JOHAN-PC\JOHANETAVERAS;Initial Catalog=Proyecto1DB;Integrated Security=True")
            Dim dr As SqlDataReader
            Dim ds As New DataSet

            Try
                conn.Open()
                Dim cmd As New SqlCommand("Select * from TBL_USUARIO where USUARIO='" & Me.TextBox1.Text & "'" & " and Clave='" & Me.TextBox2.Text & "'", conn)
                dr = cmd.ExecuteReader
                If (dr.HasRows = True) Then
                    MessageBox.Show("Bienvenido a Nuestro Sistema")
                    Me.Hide()
                    MenuFrm.Show()

                ElseIf (dr.HasRows = False) Then
                    MessageBox.Show("Nombre o Clave Incorrecta")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                End If
            Catch projectodb As Exception
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class