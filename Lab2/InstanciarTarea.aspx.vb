Imports System.Data.SqlClient
Imports BD.accesodatosSQL

Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim Usuario As String
        Dim CodTarea As String

        'Variables DataSource
        Dim DATareas As SqlDataAdapter
        Dim DSTareas As New DataSet
        Dim DTTareas As DataTable

        Usuario = Session("email")
        CodTarea = Request.QueryString("codigo")

        LabelUsuario.Text = Usuario
        LabelCodTarea.Text = CodTarea

        DATareas = New SqlDataAdapter("select * from EstudiantesTareas where Email='" & Usuario & "'", getConexion())

        DATareas.Fill(DSTareas, "TareasEspecificasAlumno")

        DTTareas = DSTareas.Tables("TareasEspecificasAlumno")

        GridViewTareasAsignatura.DataSource = DTTareas
        GridViewTareasAsignatura.DataBind()

    End Sub

    Protected Sub ButtonCrearTarea_Click(sender As Object, e As EventArgs) Handles ButtonCrearTarea.Click

        Dim HEstimadas As Integer
        Dim HReales As Integer
        Dim Usuario As String
        Dim CodTarea As String

        'Variables DataSource
        Dim DATareas As SqlDataAdapter
        Dim DSTareas As New DataSet
        Dim DTTareas As DataTable
        Dim DRTareas As DataRow

        Usuario = Session("email")
        CodTarea = LabelCodTarea.Text
        HEstimadas = TextBoxHEstimadas.Text
        HReales = TextBoxHReales.Text

        DATareas = New SqlDataAdapter("select Email, CodTarea, HEstimadas, HReales from EstudiantesTareas where Email='" & Usuario & "'", getConexion())
        Dim Builder As SqlCommandBuilder = New SqlCommandBuilder(DATareas)

        DATareas.InsertCommand = Builder.GetInsertCommand

        DATareas.Fill(DSTareas, "TareasEspecificasAlumno")

        DTTareas = DSTareas.Tables("TareasEspecificasAlumno")

        DRTareas = DTTareas.NewRow()

        DRTareas("Email") = Usuario
        DRTareas("CodTarea") = CodTarea
        DRTareas("HEstimadas") = HEstimadas
        DRTareas("HReales") = HReales

        DTTareas.Rows.Add(DRTareas)

        Try
            DATareas.Update(DSTareas, "TareasEspecificasAlumno")
            DTTareas.AcceptChanges()

            GridViewTareasAsignatura.DataSource = DTTareas
            GridViewTareasAsignatura.DataBind()

            LabelInsertTrue.Text = "Inserción Correcta"
            LabelInsertTrue.Visible = True
        Catch ex As Exception
            LabelInsertTrue.Text = ex.Message
            LabelInsertTrue.Visible = True
        End Try
    End Sub
End Class