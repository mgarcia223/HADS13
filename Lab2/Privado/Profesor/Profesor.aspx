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
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
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
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="TareasProfesor.aspx">Tareas</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" ForeColor="Blue">Grupos</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" ForeColor="Blue" NavigateUrl="ImportarTareas.aspx">Importar v. XMLDocument</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" ForeColor="Blue" NavigateUrl="ExportarTareas.aspx">Exportar</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink6" runat="server" ForeColor="Blue" NavigateUrl="ImportarTareas_DataSet.aspx">Importar v. DataSet</asp:HyperLink>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Cerrar Sesion</asp:LinkButton>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="5000">
                </asp:Timer>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Numero de Profesores online:"></asp:Label>
                &nbsp;<asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <br />
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="107px" Width="164px"></asp:ListBox>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    
    </div>
    </form>
</body>
</html>
