<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TutuCanchas_GP1.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <div class="container">
        <div class="row"></div>
        <div class="col-md-4">
            <asp:Image ID="ftoperfil" runat="server" Height="152px"  ImageUrl="img/perfil.jpg" Width="152px"/>
            <div class="col-md-12 text-center w-75" style="float: right">
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="None"></asp:Label>
            </div>
        </div>
    
    </div>
    

</asp:Content>

