Imports System.Data.SqlClient
Imports BD.accesodatosSQL


Public Class InsertarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
            Dim rowMbrs As DataRow = tblMbrs.NewRow()
            rowMbrs("Codigo") = codigo.Text
            rowMbrs("Descripcion") = desc.Text
            rowMbrs("CodAsig") = codAsig.SelectedItem.Text
            rowMbrs("HEstimadas") = horas.Text
            rowMbrs("TipoTarea") = tarea.SelectedItem.Text
            rowMbrs("Explotacion") = 0
            tblMbrs.Rows.Add(rowMbrs)

            dapMbrs.Update(dstMbrs, "TareasGenericas")
            tblMbrs.AcceptChanges()

        Catch ex As Exception
            Label1.Text = ex.Message
            Label1.Visible = True
        End Try


    End Sub

    Protected Sub codAsig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles codAsig.SelectedIndexChanged

    End Sub
End Class