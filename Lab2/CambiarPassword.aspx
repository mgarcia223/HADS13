<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CambiarPassword.aspx.vb" Inherits="Lab2.Cambiar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body style="height: 294px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Introduce tu dirección de email<br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ver Pregunta" style="height: 26px" />
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Pregunta:" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Respuesta:" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Obligatorio" ForeColor="Red" Visible="False"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Enviar Respuesta" Visible="False" />
        <br />
        <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="Respuesta Incorrecta" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Contraseña:" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Visible="False" TextMode="Password"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Obligatorio" ForeColor="Red" Visible="False"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Repetir Contraseña:" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" Visible="False" TextMode="Password"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Obligatorio" ForeColor="Red" Visible="False"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="No coinciden" ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Cambiar Contraseña" Visible="False" />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
