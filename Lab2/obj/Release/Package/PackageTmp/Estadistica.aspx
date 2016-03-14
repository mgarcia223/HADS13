<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Estadistica.aspx.vb" Inherits="Lab2.Estadistica" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Estadistica de la dedicacion real de horas a cada asignatura "></asp:Label>
        <br />
        <br />
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
            <series>
                <asp:Series Name="Series1" XValueMember="CodAsig" YValueMembers="Expr1" YValuesPerPoint="2">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AsignaturasProfesor %>" SelectCommand="SELECT TareasGenericas.CodAsig, SUM(EstudiantesTareas.HReales) AS Expr1 FROM EstudiantesTareas INNER JOIN TareasGenericas ON EstudiantesTareas.CodTarea = TareasGenericas.Codigo WHERE (EstudiantesTareas.Email = @Email) GROUP BY TareasGenericas.CodAsig">
            <SelectParameters>
                <asp:SessionParameter Name="Email" SessionField="email" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
