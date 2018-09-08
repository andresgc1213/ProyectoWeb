<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="Proyecto.Web.Views.Agregar_Articulo.AgregarArticulo" %>

<asp:Content ID="ContenHeader" ContentPlaceHolderID="header" runat="server">
    <script src="../../css/sweetalert.css" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" type="text/css" rel="stylesheet"/>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mx-auto mt-5" runat="server">
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12 mx-3">
                    <asp:Label runat="server" Text="AGREGAR ARTICULO" Font-Size="XX-Large" ForeColor="DarkGoldenrod" Font-Bold="true"></asp:Label>
                    <hr />
                    <hr />
                    <asp:Label runat="server" ID="lblOpcion"></asp:Label>
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" Font-Bold="true">Nombre</asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" Font-Bold="true">Cantidad</asp:Label>
                    <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" Font-Bold="true">Valor</asp:Label>
                    <asp:TextBox ID="txtValor" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4">
                    <asp:Label runat="server" Font-Bold="true">Proveedor</asp:Label>
                    <asp:TextBox ID="txtProveedor" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" Font-Bold="true">Tipo</asp:Label>
                    <asp:TextBox ID="txtTipo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-2">
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-block btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>

</asp:Content>
