Imports BD.accesodatosSQL
Imports System.Data.SqlClient

Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'ALUMNO
        'TextBox1.Text = "jon@ikasle.ehu.es"

        'PROFE
        'TextBox1.Text = "vadillo@ehu.es"

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim email As String
        Dim pass As String
        Dim tipodef As String
        Dim tipo As SqlDataReader

        email = TextBox1.Text
        pass = TextBox2.Text

        conectar()
        tipo = login(email, pass)


        If tipo.HasRows Then
            tipo.Read()
            tipodef = tipo.Item("tipo")
            Session("email") = email
            tipo.Close()

            If tipodef = "P" Then
                Response.Redirect("Profesor.aspx")
            Else
                Response.Redirect("Alumno.aspx")
            End If
        Else
            Label1.Visible = True
        End If
        cerrarconexion()
    End Sub
End Class