<%@ Page Title="Dirección de Tránsito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Exámen Final - Electiva de Programación</h2>

        <br />

        <h4>INFRACCIONES DE TRÁNSITO</h4>

        <br />

        <p style="font-size:110%;">El sistema debe administrar el registro y pago de infracciones de tránsito cometidas por los
            automovilistas. De las infracciones se conoce su código, la descripción de la misma y el
            importe correspondiente. Para registrar una infracción es necesario conocer el dominio del
            vehículo y la fecha del suceso. La fecha de vencimiento para el pago de una infracción es 30
            días después de cometida la misma. Las infracciones leves tienen un 25 % de descuento si se
            pagan 20 días antes de su vencimiento y un 15% si se pagan 10 días antes. Las infracciones
            graves sólo tienen un 20% de descuento si se pagan 25 días antes de su vencimiento.
        </p>

        <br />

        <p style="font-size:110%;">
            Realizar una aplicación de escritorio que mínimamente permita:
        </p>
        <ol>
            <li>Agregar y/o modificar un tipo de infracción.</li>
            <li>Registrar una infracción cometida por un vehículo.</li>
            <li>Realizar el pago de una infracción.</li>
        </ol>

        <br />

        <p style="font-size:110%;">
            Realizar una aplicación Web que permita al dueño de un vehículo consultar si posee
            infracciones pagas y/o impagas. En el caso de tener infracciones impagas, generar un pdf con
            la orden de pago correspondiente.

            Mantener la persistencia de datos con base de datos.
        </p>
    </div>

    <div class="row">
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
