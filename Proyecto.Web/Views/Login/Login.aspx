<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto.Web.Views.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>VINIL COLOR`s - Login</title>
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
    <div class="col-md-4 mt-5 mx-5 ">
        <div class="card-footer">
            <h2 style="color: aliceblue"><b>Iniciar Sesion</b></h2>
        </div>
        <div class="card-body">
            <form runat="server">
                <div class="form-group">
                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su usuario</asp:Label>
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su contraseña</asp:Label>
                    <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <div class="form-check">
                        <asp:CheckBox ID="chkRecordar" runat="server" Text=" Recordar datos" ForeColor="White" />
                    </div>
                </div>
                <asp:Button ID="btnInicioSesion" runat="server" CssClass="btn btn-primary btn-block" Text="Iniciar" OnClick="btnInicioSesion_Click" />
            </form>
            <div class="text-lg-right">
                <a class="d-block small mt-5" href="../Recuperar Password/RecuperarPassword.aspx"><b>¡Olvide mi contraseña!</b></a>
                <a class="d-block small" href="../Registrar Usuario/RegistrarUsuario.aspx"><b>Registrarme!</b></a>
            </div>
        </div>
    </div>
    <div class="col-1"></div>



</body>
</html>
