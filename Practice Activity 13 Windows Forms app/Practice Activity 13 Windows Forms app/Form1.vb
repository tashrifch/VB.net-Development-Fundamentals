Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddThis.Click
        TextDisplay.AppendText("This ")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextDisplay.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AddIs.Click
        TextDisplay.AppendText("is ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addProgram.Click
        TextDisplay.AppendText("program.")
    End Sub

    Private Sub addmy_Click(sender As Object, e As EventArgs) Handles addmy.Click
        TextDisplay.AppendText("my ")
    End Sub
End Class
