Imports BD.accesodatosSQL

Public Class Confirmar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim email As String
        Dim numConf As Integer
        Dim es As Boolean

        email = Request.QueryString("mbr")
        numConf = Request.QueryString("numconf")

        conectar()
        es = confirmarCod(email, numConf)
        cerrarconexion()

        If es Then
            Label1.Text = "Confirmación Correcta"
        Else
            Label1.Text = "Error en la confirmación"
        End If

        HyperLink1.Visible = True

    End Sub

End Class