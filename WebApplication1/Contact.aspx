<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h3>
            <asp:Image ID="contacto" ImageUrl="~/imagenes/contacto.png" runat="server" Height="30px" Width="30px" />
            Contacto
        </h3>

        <br />

        <p style="font-size:110%;">
            Web realizada por:
        </p>

        <address>
            <strong>Matias Leonel Garcia:</strong>   <a href="mailto:matu.garcia@hotmail.com.ar">matu.garcia@hotmail.com.ar</a><br />
            <strong>Sebastian Martinez:</strong> <a href="mailto:sebastianmartinez@hotmail.com">sebastianmartinez@hotmail.com</a>
        </address>
    </div>
</asp:Content>
