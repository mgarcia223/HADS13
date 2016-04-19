Public Class Profesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Dim ListaProf As New ArrayList
        ListaProf = Application("ListaProf")
        ListaProf.Remove(Session("email"))
        Application("ListaProf") = ListaProf
        Application("NumProf") = Application("NumProf") - 1
        Session.Abandon()
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Application("NumProf")
        ListBox1.Items.Clear()
        Dim ListaProf As ArrayList
        ListaProf = Application("ListaProf")
        For Each email As String In ListaProf
            ListBox1.Items.Add(email)
        Next
    End Sub
End Class