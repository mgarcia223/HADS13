<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registro.aspx.vb" Inherits="Lab2.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div style="text-align: left">
    
        Email:
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<br />
        <br />
        Nombre: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Primer
        Apellido:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Segundo Apellido:<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox9" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        DNI:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Password:
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Repetir password:
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ErrorMessage="Contraseñas diferentes" ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        Pregunta secreta:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Respuesta:
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" ErrorMessage="Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Registrar" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Visible="False">Se le enviara un email al correo facilitado para confirmar su cuenta</asp:Label>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
