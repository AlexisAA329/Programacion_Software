<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Parcial.aspx.cs" Inherits="pSitioWEB_Parciales.BaseDatos.Parcial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 80%">
        <tr>
            <td colspan="2">
                <h2 class="text-center"><strong><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Venta Vestidos </em></strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h2>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                Codigo:</td>
            <td class="text-center">
                <asp:TextBox ID="txtCodigo" runat="server" style="font-size: x-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                Cedula:</td>
            <td class="text-center">
                <asp:TextBox ID="txtCedula" runat="server" style="font-size: x-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                Nombre:</td>
            <td class="text-center">
                <asp:TextBox ID="txtNombre" runat="server" style="font-size: x-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                Fecha En Que Visita</td>
            <td class="text-center">
                <asp:TextBox ID="txtFecha" runat="server" style="font-size: x-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                Tipo De Apartamento</td>
            <td class="text-center">
                <asp:DropDownList ID="cboTipoApartamento" runat="server" style="font-size: x-large">
                    <asp:ListItem>DUPLEX</asp:ListItem>
                    <asp:ListItem>APARTA ESTUDIO</asp:ListItem>
                    <asp:ListItem>PENTHOUSE</asp:ListItem>
                    <asp:ListItem>OTRO</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                Numero De Metros Cuadrados</td>
            <td class="text-center">
                <asp:TextBox ID="txtNumMetros" runat="server" style="margin-left: 0px; font-size: x-large;"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px; height: 34px;">
                </td>
            <td class="text-center" style="height: 34px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                &nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px; text-align: center;">
                <h4>
                    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" style="font-size: x-large; color: #000000" Text="Consultar" />
                </h4>
            </td>
            <td class="text-center">
                <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" style="font-size: x-large" Text="Registrar" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px; text-align: center;">
                <h4>
                    <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" style="font-size: x-large" Text="Actualizar" />
                </h4>
            </td>
            <td class="text-center">
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" style="font-size: x-large" Text="Eliminar" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px; text-align: center;">
                <h4 class="text-left">
                <asp:Label ID="lblError" runat="server" style="font-size: x-large" Text="Error"></asp:Label>
                </h4>
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>&nbsp;</h4>
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>Valor Del Apartamento:</h4>
            </td>
            <td class="text-center">
                <asp:Label ID="lblValorApartamento" runat="server" style="font-size: x-large" Text="-"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>&nbsp;</h4>
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>&nbsp;</h4>
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 265px">
                <h4>
                    &nbsp;</h4>
            </td>
            <td class="text-center">
                    &nbsp;</td>
        </tr>
    </table>
</asp:Content>

