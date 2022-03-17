using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using libProgramacionSoftware.BaseDatos;

namespace pSitioWEB_Prog.BaseDatos
{
    public partial class Facturacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblFecha.Text = DateTime.Now.ToString("yyyy-MMM-dd");
                LlenarComboTipoProducto();
                LlenarComboEmpleado();
            }
        }
        private void LlenarComboTipoProducto()
        {
            clsTipoProducto oTipoProducto = new clsTipoProducto();
            oTipoProducto.cboTipoProducto = cboTipoProducto;

            if (!oTipoProducto.LlenarCombo())
            {
                lblError.Text = oTipoProducto.Error;
            }
            else
            {
                //Se llenó el combo de tipo de producto, se invoca el método para llenar el combo de productos
                LlenarComboProductos();
            }
        }
        private void LlenarComboEmpleado()
        {
            clsEmpleado oEmpleado = new clsEmpleado();
            oEmpleado.cboEmpleado = cboEmpleado;

            if (!oEmpleado.LLenarCombo())
            {
                lblError.Text = oEmpleado.Error;
            }
        }
        private void LlenarComboProductos()
        {
            //Hay que leer el tipo de producto
            Int32 CodigoTipoProducto = Convert.ToInt32(cboTipoProducto.SelectedValue);

            clsProducto oProducto = new clsProducto();
            oProducto.cboProducto = cboProducto;
            //Se pasa el tipo de producto a la clase producto
            oProducto.CodigoTipoProducto = CodigoTipoProducto;

            if (!oProducto.LlenarCombo())
            {
                lblError.Text = oProducto.Error;
            }
            else
            {
                if (cboProducto.Items.Count > 0)
                {
                    //Llenó el combo de productos, se invoca el método para consultar el valor unitario
                    ConsultarPrecioUnitario();
                }
                else
                {
                    lblValor.Text = "0";
                    lblValorUnitario.Text = "0";
                    CalcularSubtotal();
                }
            }
        }
        private void ConsultarPrecioUnitario()
        {
            Int32 CodigoProducto = Convert.ToInt32(cboProducto.SelectedValue);
            clsProducto oProducto = new clsProducto();
            oProducto.Codigo = CodigoProducto;

            if (oProducto.Consultar())
            {
                lblValor.Text = "$ "  + oProducto.ValorUnitario.ToString("#,###"); //Es visible
                lblValorUnitario.Text = oProducto.ValorUnitario.ToString();
                //Calcula el subtotal
                CalcularSubtotal();
            }
            else
            {
                lblError.Text = oProducto.Error;
            }
        }
        private void CalcularSubtotal()
        {
            Int32 Cantidad, ValorUnitario, Subtotal;

            Cantidad = Convert.ToInt32(txtCantidad.Text);
            ValorUnitario = Convert.ToInt32(lblValorUnitario.Text);

            Subtotal = Cantidad * ValorUnitario;

            lblSubtotal.Text = "$ " + Subtotal.ToString("#,###");
        }
        private void LlenarGrid()
        {
            clsFacturacion oFacturacion = new clsFacturacion();
            oFacturacion.grdFacturacion = grdFactura;
            oFacturacion.NumeroFactura = Convert.ToInt32(lblNumeroFactura.Text);
            if (!oFacturacion.LlenarGrid())
            {
                lblError.Text = oFacturacion.Error;
            }
        }
        protected void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            string DocumentoCliente;
            Int32 NumeroFactura, Empleado, Producto, ValorUnitario;
            Int16 Cantidad;

            DocumentoCliente = txtDocumento.Text;
            if (lblNumeroFactura.Text == "")
            {
                NumeroFactura = 0;
            }
            else 
            {
                NumeroFactura = Convert.ToInt32(lblNumeroFactura.Text);
            }
            Empleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            Producto = Convert.ToInt32(cboProducto.SelectedValue);
            ValorUnitario = Convert.ToInt32(lblValorUnitario.Text);
            Cantidad = Convert.ToInt16(txtCantidad.Text);

            clsFacturacion oFacturacion = new clsFacturacion();

            oFacturacion.DocumentoCliente = DocumentoCliente;
            oFacturacion.NumeroFactura = NumeroFactura;
            oFacturacion.EmpleadoCargo = Empleado;
            oFacturacion.Producto = Producto;
            oFacturacion.ValorUnitario = ValorUnitario;
            oFacturacion.Cantidad = Cantidad;

            if (oFacturacion.Grabar())
            {
                //Se captura el número de la factura
                lblNumeroFactura.Text = oFacturacion.NumeroFactura.ToString();
                lblTotal.Text = "$ " + oFacturacion.Total.ToString("#,###");
                //LLenar el grid
                LlenarGrid();
            }
            else
            {
                //Captura el error
                lblError.Text = oFacturacion.Error;
            }
        }

        protected void btnBuscarCliente_Click(object sender, ImageClickEventArgs e)
        {
            string Documento = txtDocumento.Text;

            clsCliente oCliente = new clsCliente();

            oCliente.Documento = Documento;
            if (oCliente.Consultar())
            {
                lblNombreCliente.Text = oCliente.NombreApellidos;
                lblError.Text = "";
                btnCrearCliente.Visible = false;
            }
            else
            {
                if (oCliente.Error.Substring(0, 32) == "No existen datos para el cliente")
                {
                    //El cliente no existe, se debería ofrecer la posibilidad de crearlos
                    //Primero se debe volver visible el botón de Crear cliente
                    btnCrearCliente.Visible = true;
                    lblNombreCliente.Text = "No existe el cliente, desea crearlo?";
                    lblError.Text = "";
                }
                else
                {
                    lblNombreCliente.Text = "-";
                    lblError.Text = oCliente.Error;
                    btnCrearCliente.Visible = false;
                }
            }
        }

        protected void btnTerminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboProductos();
        }

        protected void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarPrecioUnitario();
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }
    }
}