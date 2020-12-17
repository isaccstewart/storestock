Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "blue" Then
            Me.BackColor = Color.Blue
            Button1.Text = "green"
            MessageBox.Show("changed to blue")
        ElseIf Button1.Text = "green" Then
            Me.BackColor = Color.Green
            Button1.Text = "blue"
            MessageBox.Show("changed to green")

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(115, 115, 115)

    End Sub
End Class