Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim myWeb = New webs.Activity12WebService
        Response.Write(myWeb.HelloWorld)
        Response.Write(myWeb.JoinStrings("hey", "whats up"))


    End Sub
End Class