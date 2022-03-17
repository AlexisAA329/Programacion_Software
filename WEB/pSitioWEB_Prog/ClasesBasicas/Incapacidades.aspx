<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Incapacidades.aspx.cs" Inherits="pSitioWEB_Sab.Talleres.Incapacidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="nav-justified">
            <tr>
                <td class="text-center" colspan="2" style="font-size: xx-large"><strong>EPS - INCAPACIDADES</strong></td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>TIPO DE ENFERMEDAD</strong></td>
                <td>
                    <asp:DropDownList ID="cboTipoEnfermedad" runat="server" style="font-size: x-large">
                        <asp:ListItem>GRIPA</asp:ListItem>
                        <asp:ListItem>VIRAL</asp:ListItem>
                        <asp:ListItem>BACTERIAL</asp:ListItem>
                        <asp:ListItem>CIRUGIA MENOR</asp:ListItem>
                        <asp:ListItem>CIRUGIA MAYOR</asp:ListItem>
                        <asp:ListItem>COVID 19</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="text-center" colspan="2">
                    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" style="font-size: x-large" Text="INCAPACIDAD" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblError" runat="server" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr style="font-size: x-large">
                <td><strong>DÍAS INCAPACIDAD</strong></td>
                <td>
                    <asp:Label ID="lblDiasIncapacidad" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
