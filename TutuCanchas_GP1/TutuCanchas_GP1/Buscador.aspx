<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Buscador.aspx.cs" Inherits="TutuCanchas_GP1.Buscador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container">

        <div class="row">

            <div class="col-md-12" style="width: auto; text-align: center;">

                <h3 style="font-size: 20px; text-decoration: underline">Buscador</h3>

                <asp:Label ID="Label1" runat="server" Text="Horario"></asp:Label>
                <asp:DropDownList ID="ddHorario" runat="server" class="custom-select d-block w-100" Width="100%" ></asp:DropDownList>

                <br />
                <asp:Label ID="Label2" runat="server" Text="Tipo de Cancha"></asp:Label>
                <asp:DropDownList ID="ddTipoCancha" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>

                <br />
                <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
                <asp:TextBox ID="txPrecio" runat="server" class="form-control" TextMode="Number"></asp:TextBox>

                <br />
                <asp:Label ID="Label4" runat="server" Text="Zonas"></asp:Label>
                <asp:DropDownList ID="ddZonas" runat="server" class="custom-select d-block w-100" Width="100%" ></asp:DropDownList>

                <br />
                <asp:Label ID="lbMsg" runat="server"></asp:Label>

                <br />
                <br />
                
                <asp:Button ID="btBuscar" runat="server" Text="Buscar" class="btn btn-primary btn-lg" OnClick="btBuscar_Click" Width="200px"  />

            </div>
        </div>
        <div class="row">

        </div>
    </div>

</asp:Content>
