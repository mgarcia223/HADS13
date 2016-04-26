<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PreRegistro.aspx.vb" Inherits="Lab2.PreRegistro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Introduce tu email para verficar que estes matriculado."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Verificar" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
