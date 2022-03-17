<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlquilerVestidos.aspx.cs" Inherits="pSitioWEB_Sab.Talleres.AlquilerVestidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="nav-justified">
            <tr style="font-size: xx-large">
                <td class="text-center" colspan="2">ALQUILER DE VESTIDOS</td>
            </tr>
            <tr style="font-size: x-large">
                <td><strong>VESTIDO:</strong></td>
                <td class="text-center">
                    <asp:DropDownList ID="cboVestidos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboVestidos_SelectedIndexChanged" style="font-size: x-large">
                        <asp:ListItem Value="200000">VESTIDO NOVIA</asp:ListItem>
                        <asp:ListItem Value="120000">VESTIDO FIESTA</asp:ListItem>
                        <asp:ListItem Value="60000">DISFRAZ</asp:ListItem>
                        <asp:ListItem Value="80000">ESMOQUIN</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="text-center" colspan="2">
                    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" style="font-size: xx-large" Text="CALCULAR" />
                </td>
            </tr>
            <tr style="font-size: x-large">
                <td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr style="font-size: x-large">
                <td><strong>VALOR:</strong></td>
                <td class="text-center">
                    <asp:Label ID="lblValor" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
