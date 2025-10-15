Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Load")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstNumber.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddTogether.Click
        Try
            MessageBox.Show("The total is" &
                        (CDbl(FirstNumber.Text) + CDbl(SecondNumber.Text)))

        Catch ex As Exception
            MessageBox.Show("Please enter only numbers")

        End Try

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MsgBox("Shown")
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub
End Class
