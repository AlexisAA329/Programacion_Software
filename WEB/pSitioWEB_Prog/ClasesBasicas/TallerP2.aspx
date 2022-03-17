<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TallerP2.aspx.cs" Inherits="pSitioWEB_Prog.ClasesBasicas.TallerP2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td colspan="2">
                <h4 class="text-center">Venta de equipos de computo</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px">Tipo de equipo</td>
            <td class="modal-sm" style="width: 498px">
                <asp:DropDownList ID="cboTipoDeEquipo" runat="server">
                    <asp:ListItem>Portatil</asp:ListItem>
                    <asp:ListItem Value="Todo En Uno">Todo en uno</asp:ListItem>
                    <asp:ListItem>PC Gamer</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px">Mouse Inalambrico</td>
            <td class="modal-sm" style="width: 498px">
                <asp:CheckBox ID="chkMouseInalambrico" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px; height: 26px">DiscoDuro</td>
            <td class="modal-sm" style="width: 498px; height: 26px">
                <asp:CheckBox ID="chkDiscoDuro" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" />
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 539px">Memoria</td>
            <td class="modal-sm" style="width: 498px">
                <asp:CheckBox ID="chkMemoria" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px">
                <asp:Button ID="btnCalcular" runat="server" OnClick="Button1_Click" Text="Calcular" />
            </td>
            <td class="modal-sm" style="width: 498px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px">Iva</td>
            <td class="modal-sm" style="width: 498px">
                <asp:Label ID="lblIva" runat="server" Text="-"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px">SubTotal</td>
            <td class="modal-sm" style="width: 498px">
                <asp:Label ID="lblSubTotal" runat="server" Text="-"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px">Total</td>
            <td class="modal-sm" style="width: 498px">
                <asp:Label ID="lblTotal" runat="server" Text="-"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 539px">Porcentaje Iva</td>
            <td class="modal-sm" style="width: 498px">
                <asp:Label ID="lblPorcentajeIva" runat="server" Text="-"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
