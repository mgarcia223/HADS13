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
        Dim passbru As String
        Dim tipodef As String
        Dim tipo As SqlDataReader

        email = TextBox1.Text
        passbru = TextBox2.Text

        Dim sha1Obj As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(passbru)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim pass As String = ""

        For Each b As Byte In bytesToHash
            pass += b.ToString("x2")
        Next
        conectar()
        tipo = login(email, pass)


        If tipo.HasRows Then
            tipo.Read()
            tipodef = tipo.Item("tipo")
            Session("email") = email

            'Creamos la cookie

            tipo.Close()

            If tipodef = "P" Then
                If email = "vadillo@ehu.es" Then
                    System.Web.Security.FormsAuthentication.SetAuthCookie("vadillo@ehu.es", True)
                Else
                    System.Web.Security.FormsAuthentication.SetAuthCookie("Profesor", True)
                End If
                Response.Redirect("Privado/Profesor/Profesor.aspx")
            Else
                If tipodef = "A" Then
                    System.Web.Security.FormsAuthentication.SetAuthCookie("Alumno", True)
                    Response.Redirect("Privado/Alumno/Alumno.aspx")
                Else
                    If email = "admin@ehu.es" Then
                        System.Web.Security.FormsAuthentication.SetAuthCookie("admin@ehu.es", True)
                        Response.Redirect("Privado/Administrador/Usuarios.aspx")
                    End If
                End If
            End If

        Else
            Label1.Visible = True
        End If
        cerrarconexion()
    End Sub
End Class