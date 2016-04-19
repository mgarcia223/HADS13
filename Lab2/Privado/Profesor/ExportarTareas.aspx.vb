Imports BD.accesodatosSQL
Imports System.Data.SqlClient
Imports System.Xml

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub

    Protected Sub ButtonExportar_Click(sender As Object, e As EventArgs) Handles ButtonExportar.Click

        Dim DAProfe As SqlDataAdapter
        Dim DSProfe As New DataSet
        Dim DTProfe As DataTable
        Dim email As String
        Dim codAsig As String

        Dim arc As New XmlDocument

        codAsig = DropDownList1.SelectedValue

        email = Session("email")

        DAProfe = New SqlDataAdapter("select Codigo, Descripcion, Hestimadas, Explotacion, TipoTarea from TareasGenericas where CodAsig='" & codAsig & "'", getConexion())

        DSProfe = New DataSet("Tareas")

        DAProfe.Fill(DSProfe, "Tarea")

        DTProfe = DSProfe.Tables("Tarea")

        DTProfe.Columns(0).ColumnName = "Codigo"
        DTProfe.Columns(1).ColumnName = "Descripcion"
        DTProfe.Columns(2).ColumnName = "Hestimadas"
        DTProfe.Columns(3).ColumnName = "Explotacion"
        DTProfe.Columns(4).ColumnName = "TipoTarea"

        DSProfe.WriteXml(Server.MapPath("~/App_Data/" & codAsig & "export.xml"))


        LabelExportacionCorrect.Text = "XML de " & codAsig & " Exportado Correctamente"
        ButtonETAtributo.Visible = True

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonETAtributo.Click

        Dim xml As New XmlDocument
        Dim codAsig As String

        Dim tareas As XmlNodeList
        Dim atributo As XmlAttribute

        codAsig = DropDownList1.SelectedValue

        xml.Load(Server.MapPath("App_Data/" & codAsig & "export.xml"))

        atributo = xml.CreateAttribute("xmlns:has")

        atributo.Value = "https://ji.ehu.es/hads"

        tareas = xml.GetElementsByTagName("Tareas")

        tareas(0).Attributes.Append(atributo)

        xml.Save(Server.MapPath("App_Data/" & codAsig & "exportConAtributo.xml"))




    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("~/Profesor.aspx")
    End Sub
End Class