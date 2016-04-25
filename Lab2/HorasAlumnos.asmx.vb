Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports BD.accesodatosSQL

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class HorasAlumnos
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function Hesti(ByVal asig As String, ByVal email As String) As Integer
        Dim medHesti As Double
        'conectar()
        medHesti = mediaHEst(asig, email)
        ' cerrarconexion()
        Return medHesti
    End Function

    <WebMethod()> _
    Public Function Hreal(ByVal asig As String, ByVal email As String) As Integer
        Dim medHreal As Double
        'conectar()
        medHreal = mediaHRea(asig, email)
        ' cerrarconexion()
        Return medHreal
    End Function

    <WebMethod()> _
    Public Function Diferencia(ByVal hesti As Integer, ByVal hreal As Integer) As Integer
        If hesti > hreal Then
            Return hesti - hreal
        Else
            Return hreal - hesti
        End If
    End Function


End Class