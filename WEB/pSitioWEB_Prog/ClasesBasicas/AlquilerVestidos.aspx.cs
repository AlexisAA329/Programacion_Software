using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pSitioWEB_Sab.Talleres
{
    public partial class AlquilerVestidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int ValorVestido;

            ValorVestido = Convert.ToInt32(cboVestidos.SelectedValue);

            lblValor.Text = "$ " + ValorVestido.ToString("#,###");
        }

        protected void cboVestidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ValorVestido;

            ValorVestido = Convert.ToInt32(cboVestidos.SelectedValue);

            lblValor.Text = "$ " + ValorVestido.ToString("#,###");
        }
    }
}