<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Direccion de Transito</h1>
        <p class="lead">La Dirección de Tránsito es una dirección de la Policía Nacional de Argentina​ cuyo fin primordial es de ejercer control de las normas de tránsito y brindar seguridad y tranquilidad a los usuarios de la red vial nacional de Argentina tanto Urbana como Rural.</p>
        <p><a class="btn btn-info" href="https://www.argentina.gob.ar/seguridadvial" target="_blank">Aprenda mas &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Multas</h2>
            <p>
                Esta pagina le permite abonar las multas que ustedes haya recibido. Mediante un simple proceso se le genera
                un cupon de pago en formato PDF que le permitira pagar su multa en cualquier PagoFacil, RapiPago o Bapro del pais.
                Tambien puede pagarlo mediante billetera electronica ya sea TAP, MercadoPago, Bimo, etc.                
            </p>
            <p>
                <a class="btn btn-secondary" href="/Busqueda">Generar PDF &raquo;</a>
                <a class="btn btn-secondary" href="https://www.mercadopago.com.ar/ayuda/pago-de-servicios_4874" target="_blank">MercadoPago &raquo;</a>
            </p>
        </div>
        <%--<div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>--%>
    </div>

</asp:Content>
