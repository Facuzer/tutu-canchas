<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TutuCanchas_GP1.Buscador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <div class="container">
        <div class="col-md-4 ">
            <asp:Image ID="ftoperfil" runat="server" Height="150px" />
            <div class="row" style="float: right">
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="None"></asp:Label>
                </div>
                <div class="row">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </div>
        </div>
    
    </div>
    

</asp:Content>

