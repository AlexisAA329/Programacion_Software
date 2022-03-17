using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libProgramacionSoftware.ClasesBasicas;

namespace pSitioWEB_Prog.ClasesBasicas
{
    public partial class TallerP1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Int16 Dias;
            double ValorUnitario;
            ValorUnitario = Convert.ToDouble(txtPrecio.Text);
            Dias = Convert.ToInt16(txtDias.Text);
            clsTallerP1 oTallerP1 = new clsTallerP1();
            oTallerP1.CanatidadDias = Dias;
            oTallerP1.ValorUnitario = ValorUnitario;
            oTallerP1.CalcularTotal();

            lblSubTotal.Text = "$ " + oTallerP1.Subtotal.ToString("#,###");
            lblIva.Text = "$ " + oTallerP1.Iva.ToString("#,###");
            lblTotal.Text = "$ " + oTallerP1.Total.ToString("#,###");
            lblDescuento.Text = "$" + oTallerP1.ValorDescuento.ToString("#,###");
            lblError.Text = "$" + oTallerP1.Error;
           
        }

        protected void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }

     
    }
