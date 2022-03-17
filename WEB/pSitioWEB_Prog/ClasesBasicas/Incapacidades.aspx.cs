using System;
using libDesarrolloSoftware.Taller;

namespace pSitioWEB_Sab.Talleres
{
    public partial class Incapacidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string TipoEnfermedad;

            TipoEnfermedad = cboTipoEnfermedad.Text;
            clsIncapacidades oIncapacidad = new clsIncapacidades();
            oIncapacidad.TipoEnfermedad = TipoEnfermedad;
            if (oIncapacidad.CalcularDiasIncapacidad())
            {
                lblDiasIncapacidad.Text = oIncapacidad.DiasIncapacidad.ToString();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = oIncapacidad.Error;
                lblDiasIncapacidad.Text = "";
            }
        }
    }
}