﻿Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports BD.accesodatosSQL
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class DedicacionNoPresencial
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function Dedicacion(ByVal asig As String) As Double
        Dim mediadef As Double
        'conectar()
        mediadef = media(asig)
        ' cerrarconexion()
        Return mediadef
    End Function

End Class