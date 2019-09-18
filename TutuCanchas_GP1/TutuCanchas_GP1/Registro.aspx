<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TutuCanchas_GP1.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12" style="width:auto; text-align:center">
                <h3 style="font-size: 20px; text-decoration: underline">Registro</h3>
                <br />
                    <div class="row">
                        <asp:Label ID="Label1" runat="server" Text="Usuario:" Font-Underline="true" Font-Bold="true"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                        <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="Label2" runat="server" Text="Contraseña:" Font-Underline="true" Font-Bold="true"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                        <asp:TextBox ID="TextBox2" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="Label3" runat="server" Text="Perfil:" Font-Underline="true" Font-Bold="true"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server" Width="100%"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="Label4" runat="server" Text="Email:" Font-Underline="true" Font-Bold="true"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                        <asp:TextBox ID="TextBox4" runat="server" Width="100%"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="Label5" runat="server" Text="Telefono:" Font-Underline="true" Font-Bold="true"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                        <asp:TextBox ID="TextBox5" runat="server" Width="100%" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <asp:Button ID="btregistrar" runat="server" Text="Registrar" class="btn btn-primary btn-lg" OnClick="Button1_Click" Width="200px" />
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
