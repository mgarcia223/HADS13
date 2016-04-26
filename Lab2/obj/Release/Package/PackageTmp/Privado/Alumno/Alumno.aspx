<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Alumno.aspx.vb" Inherits="Lab2.Alumno" %>

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
    
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Gestión Web de Tareas-Dedicación"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Alumnos"></asp:Label>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="TareasAlumno.aspx">Tareas Genericas</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="Blue">Tareas Propias</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" ForeColor="Blue">Grupos</asp:HyperLink>
    
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Cerrar Sesion</asp:LinkButton>
    
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="5000">
                </asp:Timer>
                <asp:Label ID="Label3" runat="server" Text="Numero de Alumnos online:"></asp:Label>
                &nbsp;<asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Height="103px" Width="155px"></asp:ListBox>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
