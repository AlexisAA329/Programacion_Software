using System;
using libDesarrolloSoftware.Taller;

namespace pSitioWEB_Sab.Talleres
{
    public partial class Accesorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            bool DiscoDuro, Memoria, MouseTeclado;

            DiscoDuro = chkDiscoDuro.Checked;
            Memoria = chkMemoria.Checked;
            MouseTeclado = chkMouseTeclado.Checked;

            clsVentaAccesorios oAccesorios = new clsVentaAccesorios();

            oAccesorios.MouseTeclado = MouseTeclado;
            oAccesorios.Memoria = Memoria;
            oAccesorios.DiscoDuro = DiscoDuro;

            if (oAccesorios.CalcularValorAccesorios())
            {
                lblValorAccesorios.Text = "$ " + oAccesorios.ValorAccesorios.ToString("#,###");
                lblError.Text = "";
            }
            else
            {
                lblError.Text = oAccesorios.Error;
                lblValorAccesorios.Text = "";
            }
        }
    }
}