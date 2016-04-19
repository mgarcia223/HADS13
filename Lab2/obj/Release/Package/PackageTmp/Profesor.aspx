<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="Lab2.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Gestión Web de Tareas-Dedicación"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Profesores"></asp:Label>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue">Asignaturas</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/TareasProfesor.aspx">Tareas</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" ForeColor="Blue">Grupos</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" ForeColor="Blue" NavigateUrl="~/ImportarTareas.aspx">Importar v. XMLDocument</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" ForeColor="Blue" NavigateUrl="~/ExportarTareas.aspx">Exportar</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink6" runat="server" ForeColor="Blue" NavigateUrl="~/ImportarTareas_DataSet.aspx">Importar v. DataSet</asp:HyperLink>
        <br />
    
    </div>
    </form>
</body>
</html>
