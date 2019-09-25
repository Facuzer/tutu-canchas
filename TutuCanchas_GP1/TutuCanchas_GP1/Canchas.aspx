<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canchas.aspx.cs" Inherits="TutuCanchas_GP1.Canchas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">

        <div class="row">

            <div class="col-md-12" style="width: 150%; text-align: center; top: 0px; right: 275px;">

                <asp:Gridview ID="gvCanchas" runat="server" CellPadding="4" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" Width="150%" OnSelectedIndexChanged="gvCanchas_SelectedIndexChanged" OnRowCommand="gvCanchas_RowCommand2">
                                
                    
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" />
                        <asp:ButtonField ButtonType="Button" CommandName="cmdReservar" HeaderText="Elegir" Text="Reservar" />
                        <asp:BoundField DataField="NombreCancha" HeaderText="Nombre cancha" />
                        <asp:BoundField DataField="NombreClub" HeaderText="Nombre club" />
                        <asp:BoundField DataField="Zona" HeaderText="Zona" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                        <asp:BoundField DataField="Precio" DataFormatString="{0:c}" HeaderText="Precio" />
                        <asp:BoundField DataField="Dia" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Dia" />
                        <asp:BoundField DataField="DisplayHoraDesde" HeaderText="Hora desde" />
                        <asp:BoundField DataField="DisplayHoraHasta" HeaderText="Hora hasta" />
                        <asp:BoundField DataField="CanchaTipo" HeaderText="Tipo de cancha" />

                    </Columns>
                        
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                </asp:Gridview>
            

            </div>
        </div>
        <div class="row">

        </div>
    </div>

</asp:Content>        