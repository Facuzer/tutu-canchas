﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Buscador.aspx.cs" Inherits="TutuCanchas_GP1.Buscador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <br />
        <div class="container">
            <div class="row" style="width:100%; text-align:center;">
                <div class="col-md-12 text-center" style="border-width:2px; border-color:black; border-style:solid; width : auto; text-align: center;">

                    <h3 style="font-size: 20px; text-decoration: underline">Buscador</h3>

                    <asp:Label ID="Label1" runat="server" Text="Horario"></asp:Label>
                    <asp:DropDownList ID="ddHorario" runat="server" class="custom-select d-block w-100" Width="100%" ></asp:DropDownList>

                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Tipo de Cancha"></asp:Label>
                    <asp:DropDownList ID="ddTipoCancha" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>
                    <br />    
                    <asp:Label ID="Label3" runat="server" Text="Precio" Width="100%"></asp:Label>
                    <div class="col-form-label">
                    <span><asp:Label ID="Label6" runat="server" Text="Desde" Width="100%"></asp:Label></span>
                    <span><asp:TextBox ID="txPreciomin" runat="server" class="form-control text-xl-center" TextMode="Number" Width="100%" ></asp:TextBox></span>
                    <span><asp:Label ID="Label7" runat="server" Text="Hasta" Width="100%"></asp:Label></span>
                    <span><asp:TextBox ID="txtPreciomax" runat="server" class="form-control text-xl-center" TextMode="Number" Width="100%"></asp:TextBox></span>
                    </div>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Zonas"></asp:Label>
                    <asp:DropDownList ID="ddZonas" runat="server" class="custom-select d-block w-100" Width="100%" ></asp:DropDownList>
                    <br />
                    <div class="col-md-12 text-center" style=" width: 100%;">
                            <asp:Label ID="Label5" runat="server"  Text="Fecha"></asp:Label>
                            <br />
                            <asp:Calendar ID="Calendar1" runat="server" Width="100%" ></asp:Calendar>
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <asp:Button ID="btBuscar" runat="server" Text="Buscar" class="btn btn-primary btn-lg " OnClick="btBuscar_Click" Width="100%" Font-Bold="true" />
                    </div>
                </div> 
            </div>
        </div>
        
</asp:Content>
