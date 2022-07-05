<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>
            <asp:Image ID="Imagen" runat="server" Height="39px" Width="65px" ImageUrl="~/imagenes/vehiculo.png" />
            <asp:Label ID="LabelPatente" runat="server" Text="Label"></asp:Label>
        </h2>

        <br />

        <p>
            <asp:Label ID="LabelFecha" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="LabelDescripcion" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="LabelMonto" runat="server" Text="Label"></asp:Label>
        </p>

        <br />
        <br />

        <p>
            <asp:Button class="btn btn-primary" ID="ButtonPagar" runat="server" OnClick="ButtonPagar_Click" Text="Generar cupón de pago" />
        </p>

    </div>
</asp:Content>
