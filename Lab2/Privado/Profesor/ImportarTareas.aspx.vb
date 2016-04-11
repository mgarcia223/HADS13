Imports BD.accesodatosSQL
Imports System.Xml
Imports System.Data.SqlClient

Public Class ImportarTareas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Try
            Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
        Catch ex As Exception
            Label1.Text = "No existe el fichero de esa asignatura"
            Label1.Visible = True
        End Try
       
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim docxml As New XmlDocument
        Dim dstMbrs As New DataSet
        Dim tblMbrs As New DataTable
        Dim dapMbrs As SqlDataAdapter

        Try
            Label1.Visible = False
            conectar()
            dapMbrs = New SqlDataAdapter("select * from TareasGenericas", getConexion())
            Dim bldMbrs As New SqlCommandBuilder(dapMbrs)

            dapMbrs.Fill(dstMbrs, "TareasGenericas")
            tblMbrs = dstMbrs.Tables("TareasGenericas")
            docxml.Load(Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml"))

            Dim Lastareas As XmlNodeList
            Lastareas = docxml.GetElementsByTagName("tarea")

            Dim i As Integer
            For i = 0 To Lastareas.Count - 1
                Dim rowMbrs As DataRow = tblMbrs.NewRow()
                rowMbrs("Codigo") = Lastareas(i).ChildNodes(0).ChildNodes(0).Value
                rowMbrs("Descripcion") = Lastareas(i).ChildNodes(1).ChildNodes(0).Value
                rowMbrs("CodAsig") = DropDownList1.SelectedValue
                rowMbrs("HEstimadas") = Integer.Parse(Lastareas(i).ChildNodes(2).ChildNodes(0).Value)
                rowMbrs("Explotacion") = Lastareas(i).ChildNodes(3).ChildNodes(0).Value
                rowMbrs("TipoTarea") = Lastareas(i).ChildNodes(4).ChildNodes(0).Value
                tblMbrs.Rows.Add(rowMbrs)
            Next

            dapMbrs.Update(dstMbrs, "TareasGenericas")
            tblMbrs.AcceptChanges()
            Label1.Text = "Se ha importado correctamente"
            Label1.Visible = True
        Catch ex As Exception
            Label1.Text = "Error. El fichero ya ha sido importado anteriormente."
            Label1.Visible = True
        End Try
    End Sub

    Protected Sub OrdenarCodigo_Click(sender As Object, e As EventArgs) Handles OrdenarCodigo.Click
        Try
            Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFileSortCodigo.xsl")
        Catch ex As Exception
            Label1.Text = "No existe el fichero de esa asignatura"
            Label1.Visible = True
        End Try
    End Sub

    Protected Sub OrdenarDesc_Click(sender As Object, e As EventArgs) Handles OrdenarDesc.Click
        Try
            Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFileSortDesc.xsl")
        Catch ex As Exception
            Label1.Text = "No existe el fichero de esa asignatura"
            Label1.Visible = True
        End Try
    End Sub

    Protected Sub OrdenarHEstimadas_Click(sender As Object, e As EventArgs) Handles OrdenarHEstimadas.Click
        Try
            Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFileSortHEstimadas.xsl")
        Catch ex As Exception
            Label1.Text = "No existe el fichero de esa asignatura"
            Label1.Visible = True
        End Try
    End Sub
End Class