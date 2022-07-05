<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="WebApplication1.Busqueda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p>Ingrese su patente</p>
        <asp:TextBox class="form-control form-control-lg" ID="TextBoxPatente" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Button class="btn btn-primary" ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
        </p>

    </div>

    <div _designerregion="0">
        <br />
        <asp:ListBox Style="width: 100%; max-width: 100%;" ID="ListBoxIncidentes" runat="server" Height="460px" OnSelectedIndexChanged="ListBoxIncidentes_SelectedIndexChanged" Font-Bold="False" Font-Names="Nirmala UI" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False"></asp:ListBox>
        <br />
        <asp:Button ID="ButtonSiguiente" class="btn btn-primary" runat="server" OnClick="ButtonSiguiente_Click" Text="Siguiente" />
    </div>
</asp:Content>
