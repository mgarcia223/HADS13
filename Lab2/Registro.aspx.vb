Imports BD.accesodatosSQL
Imports Email.envioEmailConfirmacion
Imports System.Security.Cryptography.SHA1

Public Class Registro

    Inherits System.Web.UI.Page

    Dim NumConf As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = Request.QueryString("mbr")
        TextBox1.Enabled = False
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim email As String
        Dim apellido1 As String
        Dim apellido2 As String
        Dim dni As String
        Dim passbru As String
        Dim p_secreta As String
        Dim r_secreta As String
        Dim nombre As String

        Dim url As String

        email = TextBox1.Text
        nombre = TextBox2.Text
        apellido1 = TextBox3.Text
        apellido2 = TextBox9.Text
        dni = TextBox4.Text
        passbru = TextBox5.Text

        Dim sha1Obj As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(passbru)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim pass As String = ""

        For Each b As Byte In bytesToHash
            pass += b.ToString("x2")
        Next

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