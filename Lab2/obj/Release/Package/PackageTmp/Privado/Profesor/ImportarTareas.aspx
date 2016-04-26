﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImportarTareas.aspx.vb" Inherits="Lab2.ImportarTareas" %>

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
        IMPORTAR TAREAS GENÉRICAS<br />
        <br />
        </strong>Seleccionar Asignatura a Importar:<strong><br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig" Height="18px" Width="141px">
        </asp:DropDownList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AsignaturasProfesor %>" SelectCommand="AsignaturasProfesor" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="profesor" SessionField="email" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <br />
        <asp:Button ID="OrdenarCodigo" runat="server" Text="Ordenar por Codigo" />
        <asp:Button ID="OrdenarDesc" runat="server" Text="Ordenar por Descripcion" />
        <asp:Button ID="OrdenarHEstimadas" runat="server" Text="Ordenar por HEstimadas" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Importar (XMLD)" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        </strong>
        <asp:LinkButton ID="LinkButton1" runat="server">Volver</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
