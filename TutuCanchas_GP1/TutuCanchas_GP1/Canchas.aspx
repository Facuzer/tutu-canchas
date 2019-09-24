<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canchas.aspx.cs" Inherits="TutuCanchas_GP1.Canchas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container">

        <div class="row">

            <div class="col-md-12" style="width: 100%; text-align: center; top: 0px; left: 0px;">
                <asp:GridView ID="gvCanchas" runat="server" CellPadding="4" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" Width="500px" OnSelectedIndexChanged="gvCanchas_SelectedIndexChanged">
                    
                <Columns>
                    <asp:ButtonField CommandName="cmdResevar" ButtonType="Button" HeaderText="Elegir" Text="Reservar"  />
                        </Columns>
                    
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>

            </div>
        </div>
        <div class="row">

        </div>
    </div>

</asp:Content>        