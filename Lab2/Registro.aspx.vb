Imports BD.accesodatosSQL
Imports Email.envioEmailConfirmacion

Public Class Registro

    Inherits System.Web.UI.Page

    Dim NumConf As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim email As String
        Dim apellido1 As String
        Dim apellido2 As String
        Dim dni As String
        Dim pass As String
        Dim p_secreta As String
        Dim r_secreta As String
        Dim nombre As String

        Dim url As String

        email = TextBox1.Text
        nombre = TextBox2.Text
        apellido1 = TextBox3.Text
        apellido2 = TextBox9.Text
        dni = TextBox4.Text
        pass = TextBox5.Text
        p_secreta = TextBox7.Text
        r_secreta = TextBox8.Text

        Randomize()
        NumConf = CLng(Rnd() * 9000000) + 1000000

        conectar()
        Label1.Text = insertarRegistro(email, nombre, apellido1, apellido2, dni, pass, p_secreta, r_secreta, NumConf)
        cerrarconexion()

        url = "http://localhost:1482/Confirmar.aspx?mbr=" & email & "&numconf=" & NumConf.ToString & ""

        enviarEmail(email, url)

        Label2.Visible = True

        'HyperLink1.NavigateUrl = "http://localhost:1482/Confirmar.aspx?mbr=" & email & "&numconf=" & NumConf.ToString & ""
        'HyperLink1.Text = "Confirmar"
        'HyperLink1.Visible = True

        
    End Sub
End Class