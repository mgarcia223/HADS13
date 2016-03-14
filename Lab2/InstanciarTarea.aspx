<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InstanciarTarea.aspx.vb" Inherits="Lab2.InstanciarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Alumnos<br />
        Instanciar Tareas Generica<br />
        <br />
        Usuario:
        <asp:Label ID="LabelUsuario" runat="server" Text="Label"></asp:Label>
        <br />
        Codigo Tarea:
        <asp:Label ID="LabelCodTarea" runat="server" Text="Label"></asp:Label>
        <br />
        Horas Estimadas:<asp:TextBox ID="TextBoxHEstimadas" runat="server"></asp:TextBox>
        <br />
        Horas Reales:<asp:TextBox ID="TextBoxHReales" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonCrearTarea" runat="server" Text="Crear Tarea" />
        <br />
        <br />
        <asp:GridView ID="GridViewTareasAsignatura" runat="server">
        </asp:GridView>
    
        <br />
        <br />
        <asp:Label ID="LabelInsertTrue" runat="server" Text="Inserción" Visible="False"></asp:Label>
    
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkVolverATA" runat="server" NavigateUrl="~/TareasAlumno.aspx">Volver a la página anterior</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
