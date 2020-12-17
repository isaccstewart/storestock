
Imports System.Data
Imports System.Data.SqlClient
Public Class Form2




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (Isformvalid()) Then
            Dim connection As SqlConnection = New SqlConnection("Data Source=EVA\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True")
            Dim command As SqlCommand = New SqlCommand("INSERT INTO [dbo].[user]
           ([name]
           ,[phone]
           ,[email]
           ,[password])
     VALUES
           ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

        End If
    End Sub

    Private Function Isformvalid() As Boolean
        If (TextBox1.Text = String.Empty) Or (TextBox2.Text = String.Empty) Or (TextBox3.Text = String.Empty) Or (TextBox4.Text = String.Empty) Or (TextBox5.Text = String.Empty) Then
            MsgBox("all feilds are mandatory")
            Return False

        ElseIf (TextBox2.Text.Length <> 10) Then
            MsgBox("phone number should be 10 digits long ")
            Return False
        ElseIf (TextBox4.Text <> TextBox5.Text) Then
            MsgBox("password do not match")
            Return False
        Else
            Return True

        End If
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox4.UseSystemPasswordChar = Not CheckBox1.Checked



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As SqlConnection = New SqlConnection("Data Source=EVA\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True")
        Dim command As SqlCommand = New SqlCommand("select * from [dbo].[user] where email = '" + TextBox6.Text + "' and password = '" + TextBox7.Text + "'", connection)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(command)
        Dim dt As DataTable = New DataTable()
        sda.fill(dt)
        If (dt.Rows.Count > 0) Then
            MsgBox("login success")
        Else
            MsgBox("failed to login")

        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
        Me.Hide()

    End Sub
End Class