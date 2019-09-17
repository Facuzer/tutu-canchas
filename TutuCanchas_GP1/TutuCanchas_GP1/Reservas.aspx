<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="TutuCanchas_GP1.Reserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="container">
            <br />
            <div class="row">
                <div class="col-md-4 text-center">
                    <asp:CheckBox ID="boxReserva1" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva2" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva3" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva4" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva5" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva6" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva7" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva8" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva9" runat="server" Text="None" />
                    <br />
                    <asp:CheckBox ID="boxReserva10" runat="server" Text="None" />
                    <br />
                    <br />
                        <asp:Button ID="btnVer" runat="server" Text="Ver" class="btn btn-primary btn-lg" OnClick="btIniciarSesion_Click" Width="200px" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
