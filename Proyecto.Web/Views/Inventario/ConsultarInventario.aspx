<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="ConsultarInventario.aspx.cs" Inherits="Proyecto.Web.Views.Inventario.ConsultarInventario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mx-auto mt-5">
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12 mx-3">
                    <asp:Label runat="server" Text="ARTICULOS" Font-Size="XX-Large" ForeColor="DarkGoldenrod" Font-Bold="true"></asp:Label>
                    <hr />
                    <hr />
                    <asp:Label runat="server" ID="lblOpcion"></asp:Label>
                </div>
                <div class="col-md-12" style="overflow: auto">
                    <asp:GridView runat="server"
                        ID="gvwDatos"
                        Width="100%"
                        AutoGenerateColumns="False"
                        EmptyDataText="No se encontraron registros" 
                        BackColor="LightGoldenrodYellow" 
                        BorderColor="Tan" 
                        BorderWidth="1px" CellPadding="2" 
                        ForeColor="Black" GridLines="None"
                        OnRowCommand="gvwDatos_RowCommand">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <Columns>
                            <asp:TemplateField HeaderText="IdProducto">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblIdProducto" Text='<%# Bind("Id_Producto")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="ID" DataField="Id_Producto" />
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                            <asp:BoundField HeaderText="Valor" DataField="Valor" />
                            <asp:BoundField HeaderText="Proveedor" DataField="Proveedor" />
                            <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                            <%-- Editar --%>
                            <asp:TemplateField HeaderText="Editar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ibEditar" runat="server" ImageUrl="~/Resources/Imagenes/Edit.png"
                                        CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <%-- Eliminar --%>
                            <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ibEliminar" runat="server" ImageUrl="~/Resources/Imagenes/Borr.gif"
                                        CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
