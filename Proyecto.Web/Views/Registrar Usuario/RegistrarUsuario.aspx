<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="Proyecto.Web.Views.Registrar_Usuario.RegistrarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>VINIL COLOR`s - Registro</title>
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

<body style="background-image: url(../../Fondos/FondoRegistro.jpg); background-position: right; background-repeat: repeat-y; background-color: black">
    <div class="col-md-6 mt-5 mx-5 ">
        <div class="card-register">
            <h3 style="color: aliceblue">Registrarse</h3>
            <div class="card-body">
                <form runat="server">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su nombre</asp:Label>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su apellido</asp:Label>
                                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-8">
                                <div class="form-label-group">
                                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su correo</asp:Label>
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-label-group">
                                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su telefono</asp:Label>
                                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Digite su contraseña</asp:Label>
                                    <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label runat="server" Style="color: aliceblue" Font-Bold="true">Confirme su contraseña</asp:Label>
                                    <asp:TextBox ID="txtConfirmarContraseña" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnRegistrarCuenta" runat="server" CssClass="btn btn-primary btn-block" Text="Registrar" OnClick="btnRegistrarCuenta_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-5" href="../Login/Login.aspx"><b>Iniciar Sesion</b></a>
                    <a class="d-block small" href="../Recuperar Password/RecuperarPassword.aspx"><b>Recuperar mi contraseña</b></a>
                </div>
            </div>
        </div>
    </div>
</body>

</html>
