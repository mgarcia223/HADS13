Imports System.Data.SqlClient

Public Class accesodatosSQL
    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand

    'Conexion bd (cambiar??)
    Public Shared Function conectar() As String
        Try
            conexion.ConnectionString = "Data Source=tcp:hads-13.database.windows.net,1433;Initial Catalog=HADS-13-BD;User ID=hads-13@hads-13;Password=MikelMarta123"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXION: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function

    Public Shared Function getConexion() As SqlConnection
        Return conexion
    End Function

    'Cerrar conexion
    Public Shared Function cerrarconexion()
        conexion.Close()
        Return True
    End Function

    'Insertar Registro
    Public Shared Function insertarRegistro(ByVal email As String, ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String, ByVal dni As String, ByVal pass As String, ByVal p_secre As String, ByVal r_secre As String, ByVal numConf As Integer) As String

        Dim st = "insert into Usuarios (email, nombre, dni, pass, pregunta, respuesta, N_Confirmacion ) values ('" & email & "','" & nombre & "','" & dni & "','" & pass & "','" & p_secre & "','" & r_secre & "', '" & numConf & "')"
        Dim numregs As Integer

        comando = New SqlCommand(st, conexion)

        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try

        Return (numregs & " registro(s) insertado(s) en la BD ")
    End Function

    'Login
    Public Shared Function login(ByVal email As String, ByVal pass As String) As SqlDataReader

        Dim st = "select tipo from Usuarios where email= '" & email & "' and pass='" & pass & "' and confirmado=1"
        comando = New SqlCommand(st, conexion)

        Try
            Return comando.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Obtener pregunta secreta
    Public Shared Function emailPregunta(ByVal email As String) As SqlDataReader
        Dim st = "select P_Secreta from Usuarios where Email= '" & email & "'"
        comando = New SqlCommand(st, conexion)

        Try
            Return comando.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Verificar respuesta secreta
    Public Shared Function emailRespuesta(ByVal email As String, ByVal respuesta As String) As Boolean
        Dim st = "select count(*) from Usuarios where Email= '" & email & "' and R_Secreta='" & respuesta & "'"
        Dim numregs As Integer

        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteScalar()
            If numregs = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    'Cambiar contraseña
    Public Shared Function cambiarPass(ByVal email As String, ByVal pass As String) As String
        Dim st = "update Usuarios set Password='" & pass & "' where Email= '" & email & "'"
        Dim numregs As Integer

        comando = New SqlCommand(st, conexion)

        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try

        Return (numregs & " registro(s) actualizado(s) en la BD ")
    End Function

    'Confirmar Usuario si los datos son correctos
    Public Shared Function confirmarCod(ByVal email As String, ByVal cod As Integer) As Boolean
        Dim query = "update Usuarios set Confirmacion=1 where Email= '" & email & "' and N_Confirmacion=" & cod & ""
        Dim numregs As Integer

        comando = New SqlCommand(query, conexion)

        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try

        If numregs = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    'video Grindview https://www.youtube.com/watch?v=QAYcP9G98hs



End Class
