<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Buscador.aspx.cs" Inherits="TutuCanchas_GP1.Buscador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <br />
        <div class="container">

            <div class="row">
            </div>
                <div class="col-md-4" style="width: 100%; text-align: center;">

                    <h3 style="font-size: 20px; text-decoration: underline">Buscador</h3>

                    <asp:Label ID="Label1" runat="server" Text="Horario"></asp:Label>
                    <asp:DropDownList ID="ddHorario" runat="server" class="custom-select d-block w-100" Width="100%" ></asp:DropDownList>

                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Tipo de Cancha"></asp:Label>
                    <asp:DropDownList ID="ddTipoCancha" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>

                    <br />
                    <div class="row text-center">
                        <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
                    </div>
                    <div class="col-md-4 text-center">
                        <div id="precio" style="display:inline-block; ">
                            <asp:TextBox ID="txPreciomin" runat="server" class="form-control" TextMode="Number" Width="50%" ></asp:TextBox>
                        
                            <asp:TextBox ID="txtPreciomax" runat="server" class="form-control" TextMode="Number" Width="50%"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Zonas"></asp:Label>
                    <asp:DropDownList ID="ddZonas" runat="server" class="custom-select d-block w-100" Width="100%" ></asp:DropDownList>

                    <br 
                    
                    <div class="row">
                        
                            <asp:Label ID="Label5" runat="server">Fecha</asp:Label>
                            <asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>
                    
                    </div>
                    <br />
                    <br />
                    <asp:Button ID="btBuscar" runat="server" Text="Buscar" class="btn btn-primary btn-lg" OnClick="btBuscar_Click" Width="200px"  />

                </div>
                <div class="row">
                </div>
            
        </div>
        
    </body>
</asp:Content>
