using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libProgramacionSoftware.ClasesBasicas;

namespace pSitioWEB_Prog.ClasesBasicas
{
    public partial class TallerP2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string TipoEquipo;

            TipoEquipo = cboTipoDeEquipo.Text;
           clcTallerP2 oTaller= new clcTallerP2();
            oTaller.TipoEquipo = TipoEquipo;
            oTaller.CalcularValorAccesorios();
            bool DiscoDuro, Memoria, MouseTeclado;

            DiscoDuro = chkDiscoDuro.Checked;
            Memoria = chkMemoria.Checked;
            MouseTeclado = chkMouseInalambrico.Checked;

        

            oTaller.MouseTeclado = MouseTeclado;
            oTaller.Memoria = Memoria;
            oTaller.DiscoDuro = DiscoDuro;

            lblSubTotal.Text = "$ " + oTaller.SubTotal.ToString("#,###");
            lblIva.Text = "$ " + oTaller.Iva.ToString("#,###");
            lblTotal.Text = "$ " + oTaller.Total.ToString("#,###");
            lblPorcentajeIva.Text = "$ " + oTaller.PorcentajeIva.ToString("#,###");





        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

       

        }
    