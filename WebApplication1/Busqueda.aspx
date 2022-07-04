<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="WebApplication1.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div _designerregion="0">
        <br />
        <asp:TextBox ID="TextBoxPatente" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Button" />
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBoxIncidentes" runat="server" Height="460px" OnSelectedIndexChanged="ListBoxIncidentes_SelectedIndexChanged" Width="474px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="ButtonSiguiente" runat="server" OnClick="ButtonSiguiente_Click" Text="Siguiente" />
        <br />
</div>
</asp:Content>
