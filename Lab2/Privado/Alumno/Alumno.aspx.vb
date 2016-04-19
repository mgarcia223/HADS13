Public Class Alumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Dim ListaAlum As New ArrayList
        ListaAlum = Application("ListaAlum")
        ListaAlum.Remove(Session("email"))
        Application("ListaAlum") = ListaAlum
        Application("NumAlum") = Application("NumAlum") - 1
        Session.Abandon()
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Application("NumAlum")
        ListBox1.Items.Clear()
        Dim ListaAlum As ArrayList
        ListaAlum = Application("ListaAlum")
        For Each email As String In ListaAlum
            ListBox1.Items.Add(email)
        Next
    End Sub
End Class