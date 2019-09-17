﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosReserva.aspx.cs" Inherits="TutuCanchas_GP1.DatosReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container">
        <div class="row">

            <div class="col-md-12" style="width: 100%; text-align: center; top: 0px; left: 0px;">

                <h3 style="font-size: 20px; text-decoration: underline; color: green">Datos de Reserva</h3>

                <asp:Label ID="Label1" runat="server" Text="Fecha:" Font-Underline="true"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblFecha" runat="server" Text="None"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Horario:" Font-Underline="true"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblHorario" runat="server" Text="None"></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Dirección:" Font-Underline="true"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDir" runat="server" Text="None"></asp:Label>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Tipo:" Font-Underline="true"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblTipo" runat="server" Text="None"></asp:Label>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Precio:" Font-Underline="true"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblPrecio" runat="server" Text="None"></asp:Label>
                <br />
                <br />

                <div class="row">
                    <div class="col-sm-4 text-center">
                        <asp:Button ID="btnConfirm" runat="server" Height="26px" Text="Confirmar" class="btn btn-primary btn-lg" OnClick="btnConfirm_Click"  Width="100px" Font-Bold="true" BackColor="Green" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBack" runat="server" Text="Volver" class="btn btn-primary btn-lg" OnClick="btnBack_Click" Height="27px" Width="100px" Font-Bold="true" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>