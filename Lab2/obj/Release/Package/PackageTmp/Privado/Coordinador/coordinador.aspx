<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="coordinador.aspx.vb" Inherits="Lab2.coordinador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Selecciona una asignatura para conocer la dedicacion real media  de los alumnos: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Asignatura: "></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
        </asp:DropDownList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AsignaturasProfesor %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="Button1" runat="server" style="height: 26px" Text="Ver horas" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Dedicacion media: "></asp:Label>
        <asp:Label ID="Label4" runat="server"></asp:Label>
    
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Volver</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
