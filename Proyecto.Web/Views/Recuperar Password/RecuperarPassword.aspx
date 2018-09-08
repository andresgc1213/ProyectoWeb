<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarPassword.aspx.cs" Inherits="Proyecto.Web.Views.Recuperar_Password.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>VINIL COLOR`s - Recuperar Clave</title>
    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet" />
    <!-- Sweet Alert for boostrap-->
    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
    <!-- Sweet Alert JavaScript-->
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
</head>
<body style="background-image: url(../../Fondos/FondoLogin.jpg); background-position: right; background-repeat: repeat-y; background-color: black">
    <div class="container">
        <div class="col-md-4 mt-5 mx-0 ">
            <div class="card-header">
                <h3 style="color: aliceblue"><b>Recuperar Contraseña</b></h3>
            </div>
            <div class="card-body">
                <div class="text-center mb-4">
                    <h3 style="color: aliceblue">Olvidaste tu contraseña?</h3>
                    <p style="color: aliceblue">Digite su usuario y enviaremos su contraseña al correo electronico registrado</p>
                    <p style="color: aliceblue">Recuerde que su usuario es su cuenta de correo electronico</p>
                </div>
                <form runat="server">
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su usuario</asp:Label>
                            <asp:TextBox ID="txtUsuarioRecuperar" runat="server" CssClass="form-control" Height="40"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button runat="server" ID="btnRecuperarContraseña" CssClass="btn btn-primary btn-block" Text="Recuperar" OnClick="btnRecuperarContraseña_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-5" href="../Registrar Usuario/RegistrarUsuario.aspx"><b>Registrarme</b></a>
                    <a class="d-block small" href="../Login/Login.aspx"><b>Iniciar sesion</b></a>
                </div>
            </div>
        </div>
    </div>


</body>
</html>
