<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TutuCanchas_GP1.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <div class="container">
        <div class="row"></div>
        <div id="box" class="col-md-12">
            <asp:Image ID="ftoperfil" runat="server" Height="153px"  ImageUrl="img/perfil.jpg" Width="151px"/>
            <div id="contenedor" class="col-md-12 w-auto">
            <div id="text" class="row" style="display:inline-block">
                <asp:Label ID="nomber" runat="server" Text="Nombre:" Width="58px"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="None"></asp:Label>
            </div>
            <br />
            <div class="row">
                <asp:Label ID="Label3" runat="server" Text="Perfil:" Width="76px"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="None"></asp:Label>
            </div>
            <div id="email" class="row">
                <asp:Label ID="Label5" runat="server" Text="Email:" Width="76px"></asp:Label>
                <asp:Label ID="Label6" runat="server" Text="None"></asp:Label>
            </div>
            <div id="telefono" class="row">
                <asp:Label ID="Label7" runat="server" Text="Teléfono:" Width="76px"></asp:Label>
                <asp:Label ID="Label8" runat="server" Text="None"></asp:Label>
            </div>
            </div>
        </div>
    
    </div>
    

    
    

    
    

    
    

</asp:Content>

