<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TallerP1.aspx.cs" Inherits="pSitioWEB_Prog.ClasesBasicas.TallerP1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 80%">
        <tr>
            <td colspan="2">
                <h2 class="text-center"><strong><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Venta Vestidos </em></strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h2>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>Precio:</h4>
            </td>
            <td class="text-center">
                <asp:TextBox ID="txtPrecio" runat="server" style="margin-left: 0px; font-size: x-large;" OnTextChanged="txtPrecio_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>Dias:</h4>
            </td>
            <td class="text-center">
                <asp:TextBox ID="txtDias" runat="server" style="font-size: x-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>
                    <asp:Button ID="btnCalcular" runat="server" BackColor="#FF6600" BorderColor="#FF6666" OnClick="Button1_Click" style="font-size: x-large" Text="Calcular" />
                </h4>
            </td>
            <td class="text-center">
                <asp:Label ID="lblError" runat="server" style="font-size: x-large" Text="Error"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>Iva:</h4>
            </td>
            <td class="text-center">
                <asp:Label ID="lblIva" runat="server" style="font-size: x-large" Text="-"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>Subtotal:</h4>
            </td>
            <td class="text-center">
                <asp:Label ID="lblSubTotal" runat="server" style="font-size: x-large" Text="-"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>Total:</h4>
            </td>
            <td class="text-center">
                <asp:Label ID="lblTotal" runat="server" style="font-size: x-large" Text="-"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>Descuento:</h4>
            </td>
            <td class="text-center">
                <asp:Label ID="lblDescuento" runat="server" style="font-size: x-large" Text="-"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>&nbsp;</h4>
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
