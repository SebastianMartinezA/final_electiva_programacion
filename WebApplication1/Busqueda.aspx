<%@ Page Title="Infracciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="WebApplication1.Busqueda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h3>
            <asp:Image ID="patente" ImageUrl="~/imagenes/patente.png" runat="server" Height="25px" Width="70px" />
            Ingrese su patente
        </h3>

        <br />

        <asp:TextBox class="form-control form-control-lg" ID="TextBoxPatente" runat="server" Height="40px" Width="230px" font-size="Medium" style='text-transform:uppercase'></asp:TextBox>

        <br />
        <br />

        <p>
            <asp:Button class="btn btn-primary" ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
        </p>
    </div>

    <div _designerregion="0">
        <br />
        <asp:ListBox Style="width: 100%; max-width: 100%;" ID="ListBoxIncidentes" runat="server" Height="460px" OnSelectedIndexChanged="ListBoxIncidentes_SelectedIndexChanged" Font-Bold="False" Font-Names="Nirmala UI" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False"></asp:ListBox>
        <br />
        <asp:Button ID="ButtonMostrar" class="btn btn-primary" runat="server" OnClick="ButtonMostrar_Click" Text="Mostrar" />
    </div>
</asp:Content>
