<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasAlumno.aspx.vb" Inherits="Lab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Alumnos Gestión de tareas genéricas<br />
        <br />
        Seleccionar Asignatura:<br />
        <asp:DropDownList ID="DropDownAsigAlum" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ButtonVerTareas" runat="server" Text="Ver Tareas" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridViewTareasAlumno" runat="server">
            <Columns>
                <asp:CommandField SelectText="Instanciar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Total horas estimadas: " Visible="False"></asp:Label>
        <asp:Label ID="Label2" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Total horas reales: " Visible="False"></asp:Label>
        <asp:Label ID="Label4" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Diferencia: " Visible="False"></asp:Label>
        <asp:Label ID="Label6" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Privado/Alumno/Estadistica.aspx">Estadistica horas reales por asignatura</asp:HyperLink>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Volver</asp:LinkButton>
        <br />
    
    </div>
    </form>
</body>
</html>
