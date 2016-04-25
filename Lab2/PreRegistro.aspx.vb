Public Class PreRegistro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mat As New Matriculas.Matriculas
        Dim email As String
        Dim res As String

        Label3.Text = ""
        email = TextBox1.Text
        res = mat.comprobar(email)

        If res = "SI" Then
            Response.Redirect("/Registro.aspx?mbr=" & email & "")
        Else
            Label3.Text = "Alumno no matriculado"
        End If
    End Sub
End Class