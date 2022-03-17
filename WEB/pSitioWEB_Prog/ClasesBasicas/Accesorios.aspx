<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Accesorios.aspx.cs" Inherits="pSitioWEB_Sab.Talleres.Accesorios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table align="center" style="width: 80%; font-size: large">
            <tr>
                <td class="text-center" colspan="2" style="font-size: x-large"><span style="font-size: xx-large"><strong>VENTA ACCESORIOS</strong></span><strong>&nbsp;</strong></td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>DISCO DURO ESTADO SÓLIDO:</strong></td>
                <td>
                    <asp:CheckBox ID="chkDiscoDuro" runat="server" style="font-size: x-large" />
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>MOUSE Y TECLADO INALÁMBRICO</strong></td>
                <td>
                    <asp:CheckBox ID="chkMouseTeclado" runat="server" style="font-size: x-large" />
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>MEMORIA 4GB</strong></td>
                <td>
                    <asp:CheckBox ID="chkMemoria" runat="server" style="font-size: x-large" />
                </td>
            </tr>
            <tr>
                <td class="text-center" colspan="2">
                    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" style="font-size: xx-large" Text="CALCULAR" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblError" runat="server" style="font-size: x-large"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>VALOR ACCESORIOS:</strong></td>
                <td>
                    <asp:Label ID="lblValorAccesorios" runat="server" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
