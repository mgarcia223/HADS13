﻿Imports BD.accesodatosSQL
Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            Dim DAAlumno As SqlDataAdapter
            Dim DSAlumno As New DataSet
            Dim DTAlumno As DataTable
            Dim email As String

            email = Session("email")

            DAAlumno = New SqlDataAdapter("select GruposClase.codigoasig from GruposClase, EstudiantesGrupo where EstudiantesGrupo.Grupo=GruposClase.codigo and EstudiantesGrupo.email='" & email & "'", getConexion())

            DAAlumno.Fill(DSAlumno, "AsignaturasAlumno")

            DropDownAsigAlum.DataSource = DSAlumno.Tables("AsignaturasAlumno")
            DropDownAsigAlum.DataTextField = "codigoasig"
            DropDownAsigAlum.DataBind()


        End If

    End Sub

    

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonVerTareas.Click

        Dim DATarea As SqlDataAdapter
        Dim DSTarea As New DataSet
        Dim DTTarea As DataTable
        Dim email As String
        Dim SelectedTask As String
        Dim horAlum As New DediAlum.HorasAlumnosSoapClient

        SelectedTask = DropDownAsigAlum.SelectedItem.Text
        email = Session("email")

        DATarea = New SqlDataAdapter("select TareasGenericas.Codigo, TareasGenericas.Descripcion, TareasGenericas.HEstimadas, TareasGenericas.TipoTarea from TareasGenericas where TareasGenericas.codAsig='" & SelectedTask & "'", getConexion())

        DATarea.Fill(DSTarea, "TareasAlumno")

        DTTarea = DSTarea.Tables("TareasAlumno")

        GridViewTareasAlumno.DataSource = DTTarea
        GridViewTareasAlumno.DataBind()

        Label1.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Label2.Text = horAlum.Hesti(DropDownAsigAlum.SelectedValue, Session("email"))
        Label4.Text = horAlum.Hreal(DropDownAsigAlum.SelectedValue, Session("email"))
        Label6.Text = horAlum.Diferencia(Label2.Text, Label4.Text)
    End Sub

    Protected Sub GridViewTareasAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridViewTareasAlumno.SelectedIndexChanged

        Dim codTarea As String

        codTarea = GridViewTareasAlumno.SelectedRow.Cells(1).Text

        Response.Redirect("InstanciarTarea.aspx?codigo=" & codTarea & "")


    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("~/Alumno.aspx")
    End Sub
End Class