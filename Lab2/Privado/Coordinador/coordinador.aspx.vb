Imports BD.accesodatosSQL
Public Class coordinador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ded As New Dedicacion.DedicacionNoPresencialSoapClient
        Dim res As Double
        Try
            res = ded.Dedicacion(DropDownList1.SelectedValue)
            Label4.Text = res
        Catch ex As Exception
            Label4.Text = 0
        End Try
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("~/Privado/Profesor/Profesor.aspx")
    End Sub
End Class