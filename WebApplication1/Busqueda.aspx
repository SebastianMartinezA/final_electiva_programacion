<%@ Page Title="Infracciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="WebApplication1.Busqueda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h3>
            <asp:Image ID="patente" ImageUrl="~/imagenes/patente.png" runat="server" Height="25px" Width="70px" />
            Ingrese su patente
        </h3>

        <br />

        <asp:TextBox class="form-control form-control-lg" ID="TextBoxPatente" runat="server" Height="40px" Width="230px" Font-Size="Medium" Style='text-transform: uppercase'></asp:TextBox>

        <br />
        <br />

        <p>
            <asp:Button class="btn btn-primary" ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
        </p>
    </div>

    <br />

    <div class="col-xs-6">
        <asp:Label ID="LabelImpagos" runat="server" Text="Impagos" Style="margin-bottom: 0px"></asp:Label>
        <asp:Button ID="ButtonMostrarImpago" class="btn btn-primary" runat="server" OnClick="ButtonMostrarImpago_Click" Text="Mostrar" Style="margin-bottom: 5px;" />
        <asp:ListBox Style="max-width: 100%;" ID="ListBoxIncidentes" SelectionMode="Single" runat="server" Height="100%" Width="100%" Font-Bold="False" Font-Names="Nirmala UI" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Rows="15"></asp:ListBox>
    </div>

    <div class="col-xs-6">
        <asp:Label ID="LabelPagos" runat="server" Text="Pagados"></asp:Label>
        <asp:Button ID="ButtonMostrarPagado" class="btn btn-primary" runat="server" OnClick="ButtonMostrarPagado_Click" Text="Mostrar" Style="margin-bottom: 5px;" />
        <asp:ListBox Style="max-width: 100%;" ID="ListBoxIncidentesPagos" SelectionMode="Single" runat="server" Height="100%" Width="100%" Font-Bold="False" Font-Names="Nirmala UI" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Rows="15"></asp:ListBox>
    </div>

    <br />
    <br />
    <br />
    <br />
    <br />

    <br />


    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />


</asp:Content>
