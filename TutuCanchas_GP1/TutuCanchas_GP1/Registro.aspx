<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TutuCanchas_GP1.Registro" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>

    <link href="~/css/Site.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="img/pelotita.png" type="image/png" sizes="32x32"/>
    <link rel="icon" href="img/pelotita.png" type="image/png" sizes="32x32"/>
    <title>Tutu Canchas - Registro</title>

</head>
    <body>
        <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12" style="width:auto; text-align:center">
                    <h3 style="font-size: 20px; text-decoration: underline; font-family:Cooper;">Registro</h3>
                    <br />
                        <div class="row">
                            <asp:Label ID="Label1" runat="server" Text="Usuario:" Font-Underline="true" Font-Bold="true"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                            <asp:TextBox ID="txtUsuario" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <br />
                        <div class="row">
                            <asp:Label ID="Label2" runat="server" Text="Contraseña:" Font-Underline="true" Font-Bold="true"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                            <asp:TextBox ID="txtContraseña" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
                        </div>
                        <br />
                        <div class="row">
                            <asp:Label ID="Label3" runat="server" Text="Perfil:" Font-Underline="true" Font-Bold="true"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPerfil" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <br />
                        <div class="row">
                            <asp:Label ID="Label4" runat="server" Text="Email:" Font-Underline="true" Font-Bold="true"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                            <asp:TextBox ID="txtEmail" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <br />
                        <div class="row">
                            <asp:Label ID="Label5" runat="server" Text="Telefono:" Font-Underline="true" Font-Bold="true"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                            <asp:TextBox ID="txtTelefono" runat="server" Width="100%" TextMode="Number" ></asp:TextBox>
                        </div>
                        <div class="row"></div>
                        <br />
                        <div class="col-md-2" style="left: 450px" >
                            <asp:Button ID="cmdRegistrar" runat="server" Text="Registrar" class="btn btn-primary btn-lg" OnClick="Button1_Click" Width="200px"  />
                        </div>
                        <div class="row"></div>
                </div>
            </div>
        </div>
        </form>
     </body>

</html>