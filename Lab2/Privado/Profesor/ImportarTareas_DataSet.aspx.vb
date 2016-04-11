Imports BD.accesodatosSQL
Imports System.Data.SqlClient
Imports System.Xml

Public Class ImportarTareas_DataSet
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
            Dim xtr As XmlReader = XmlReader.Create(Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml"))
            'dstMbrs.ReadXml(Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml"))

            While xtr.Read
                If xtr.NodeType = XmlNodeType.Element Then
                    If xtr.Name = "tarea" Then
                        xtr.Read()
                        Dim rowselect() As DataRow
                        rowselect = tblMbrs.Select("codigo='" + xtr.Value + "'")
                        If rowselect.Length < 1 Then
                            Dim rowMbrs As DataRow = tblMbrs.NewRow()
                            rowMbrs("Codigo") = xtr.Value
                            xtr.Read()
                            rowMbrs("Descripcion") = xtr.Value
                            xtr.Read()
                            rowMbrs("HEstimadas") = xtr.Value
                            xtr.Read()
                            rowMbrs("Explotacion") = xtr.Value
                            xtr.Read()
                            rowMbrs("TipoTarea") = xtr.Value
                            rowMbrs("CodAsig") = DropDownList1.SelectedValue
                            tblMbrs.Rows.Add(rowMbrs)
                        End If
                    End If
                End If
            End While
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