<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="LabelPatente" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:Label ID="LabelFecha" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="LabelDescripcion" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="LabelMonto" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="ButtonPagar" runat="server" Text="Pagar" OnClick="ButtonPagar_Click" />
    <br />
    <br />
    <br />
</asp:Content>
