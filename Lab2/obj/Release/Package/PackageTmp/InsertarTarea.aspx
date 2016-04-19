<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertarTarea.aspx.vb" Inherits="Lab2.InsertarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>PROFESOR
        <br />
        GESTION DE TAREAS GENÉRICAS</strong><br />
        <br />
        Código&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="codigo" runat="server"></asp:TextBox>
        <br />
        <br />
        Descripción&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="desc" runat="server" Height="56px" Width="618px"></asp:TextBox>
        <br />
        <br />
        Asignatura&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="codAsig" runat="server" DataSourceID="AsignaturaProfesor" DataTextField="codigoasig" DataValueField="codigoasig" Height="20px" Width="128px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="AsignaturaProfesor" runat="server" ConnectionString="<%$ ConnectionStrings:AsignaturasProfesor %>" SelectCommand="AsignaturasProfesor" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="profesor" SessionField="email" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        Horas Estimadas
        <asp:TextBox ID="horas" runat="server"></asp:TextBox>
        <br />
        <br />
        Tipo Tarea
        <asp:DropDownList ID="tarea" runat="server" Height="16px" Width="111px">
            <asp:ListItem Selected="True">Laboratorio</asp:ListItem>
            <asp:ListItem>Examen</asp:ListItem>
            <asp:ListItem>Clase</asp:ListItem>
            <asp:ListItem>Entregable</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Añadir Tarea" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/TareasProfesor.aspx">Ver Tareas</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
