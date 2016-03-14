Imports BD.accesodatosSQL
Imports System.Data.SqlClient

Public Class Cambiar

    Inherits System.Web.UI.Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pregunta As SqlDataReader
        Dim email As String

        email = TextBox1.Text
        conectar()
        pregunta = emailPregunta(email)

        If pregunta.HasRows Then
            pregunta.Read()
            Label1.Text = pregunta.Item("P_Secreta")
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            TextBox2.Visible = True
            Button2.Visible = True
            TextBox1.Enabled = False
            Button1.Enabled = False
            RequiredFieldValidator2.Visible = True
        Else
            Label1.Text = "Email incorrecto"
            Label1.Visible = True
        End If
        pregunta.Close()
        cerrarconexion()

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim respuesta As String
        Dim email As String
        Dim correcto As Boolean

        email = TextBox1.Text
        respuesta = TextBox2.Text

        conectar()
        correcto = emailRespuesta(email, respuesta)
        cerrarconexion()

        If correcto Then
            Label6.Visible = False
            Label4.Visible = True
            Label5.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            Button3.Visible = True
            TextBox2.Enabled = False
            Button2.Enabled = False
            RequiredFieldValidator3.Visible = True
            RequiredFieldValidator4.Visible = True
        Else
            Label6.Visible = True
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nuevo As String
        Dim email As String

        email = TextBox1.Text
        nuevo = TextBox3.Text

        conectar()
        Label7.Text = cambiarPass(email, nuevo)
        cerrarconexion()

        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Button3.Enabled = False

    End Sub
End Class