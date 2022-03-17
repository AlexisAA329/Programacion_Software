using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libProgramacionParciales.baseDatos;
using libProgramacionSoftware.BaseDatos;

namespace pSitioWEB_Parciales.BaseDatos
{
    public partial class Parcial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {


            string Cedula, Nombre,  TipoApartamento;
            Int16 NumMetros;
         
            DateTime Fecha;
            

            Cedula = txtCedula.Text;
            Nombre = txtNombre.Text;
            Fecha = Convert.ToDateTime(txtFecha.Text);
            TipoApartamento = cboTipoApartamento.Text;
            NumMetros = Convert.ToInt16(txtNumMetros.Text);

          

            clsParcial oParcial = new clsParcial();
            oParcial.Cedula = Cedula;
            oParcial.Nombre = Nombre;
            oParcial.Fecha = Fecha;
            oParcial.TipoApartamento = TipoApartamento;
            oParcial.NumMetrosCuadrados = NumMetros;
            



            if (oParcial.Insertar())
            {
                lblError.Text = "Se ingresó el cliente de documento: " + Cedula + " a la base de datos";
                lblError.Text = "Se ingresó el cliente de documento: " + Cedula + " a la base de datos";
                lblError.Text = "$" + oParcial.Error;
            }
            else
            {
                lblError.Text = oParcial.Error;
            }
           
            lblValorApartamento.Text = "$" + oParcial.ValorApartamento.ToString("#,###");
            lblError.Text = "$" + oParcial.Error;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            string Codigo;

            Codigo = txtCodigo.Text;

            clsParcial oParcial = new clsParcial();

            oParcial.Codigo = Codigo;

            if (oParcial.Consultar())
            {
                txtCedula.Text = oParcial.Cedula;
                txtNombre.Text = oParcial.Nombre;
                txtFecha.Text = oParcial.Fecha.ToString("yyyy-MM-dd");
                txtNumMetros.Text = oParcial.NumMetrosCuadrados.ToString();
                cboTipoApartamento.Text = oParcial.TipoApartamento;
         




                lblError.Text = "Se consultó la información";
                lblValorApartamento.Text = "$" + oParcial.ValorApartamento.ToString("#,###");
                
            }
            else
            {
                lblError.Text = oParcial.Error;

                txtNombre.Text = "";
                txtCedula.Text = "";
                txtCodigo.Text = "";
                txtFecha.Text = "";
                txtNumMetros.Text = "";               
                lblValorApartamento.Text = "";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            string Cedula, Nombre, TipoApartamento;
            Int64 NumMetros;
            String Codigo;
            DateTime Fecha;


            Codigo = txtCodigo.Text;
            Cedula = txtCedula.Text;
            Nombre = txtNombre.Text;
            Fecha = Convert.ToDateTime(txtFecha.Text);
            TipoApartamento = cboTipoApartamento.Text;
            NumMetros = Convert.ToInt16(txtNumMetros.Text);


            clsParcial oParcial = new clsParcial();
            oParcial.Codigo = Codigo;
            oParcial.Cedula = Cedula;
            oParcial.Nombre = Nombre;
            oParcial.Fecha = Fecha;
            oParcial.TipoApartamento = TipoApartamento;
            oParcial.NumMetrosCuadrados = NumMetros;

            if (oParcial.Actualizar())
            {
                lblError.Text = "Se actualizaron los datos del cliente de codigo: " + Codigo + " a la base de datos";
                lblValorApartamento.Text = "$" + oParcial.ValorApartamento.ToString("#,###");

            }
            else
            {
                lblError.Text = oParcial.Error;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string Codigo;

            Codigo = txtCodigo.Text;

            clsParcial oParcial = new clsParcial();
            oParcial.Codigo = Codigo;

            if (oParcial.Eliminar())
            {
                lblError.Text = "Se eliminó correctamente de la base de datos el código: " + Codigo;
            }
            else
            {
                lblError.Text = oParcial.Error;
            }
        }
    }
    }
