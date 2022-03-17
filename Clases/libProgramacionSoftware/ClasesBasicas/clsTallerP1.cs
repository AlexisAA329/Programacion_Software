using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libProgramacionSoftware.ClasesBasicas
{
   public class clsTallerP1
    {
        #region constructor
        public clsTallerP1() {

            CanatidadDias = 0;
            ValorUnitario = 0;
            ValorAntes = 0;
            ValorDescuento = 0;
            Total = 0;
            Iva = 0;
            Subtotal= 0;
            PorcentajeDescuento = 0;
            PorcentajeIVA = 0.19;
            Error = "";
        }
        #endregion

        #region Atributos/Propiedades

      public Int16 CanatidadDias { private get; set; }
      public double ValorUnitario { private get; set; }
        public double ValorAntes { get; private set; }
        public double ValorDescuento { get; private set; }
        public double Total { get; private set; }
        public double Iva { get; private set; }
        public double Subtotal { get; private set; }
        public string Error { get; private set; }
        private double PorcentajeIVA;
        private double PorcentajeDescuento;

        #endregion

        #region Metodos
        public void CalcularTotal() {
            CalcularDescuento();
            Total = ValorUnitario - ValorDescuento;
            CalcularSubtotal();
            CalcularIva();
           

        }

          private void CalcularSubtotal()

            {

            Subtotal = Total / (1 + PorcentajeIVA);
        }
        private void CalcularIva()
        {
            Iva = Total - Subtotal;
        }
        private void CalcularDescuento()
        {
            if (CanatidadDias == 1){
                PorcentajeDescuento = 1;
                ValorDescuento = 0;
            }
            if (CanatidadDias > 1 && CanatidadDias < 4) {
                PorcentajeDescuento = 1.05;
                ValorDescuento =ValorUnitario - (ValorUnitario / PorcentajeDescuento);
                ValorAntes = ValorUnitario;
            }
            if (CanatidadDias > 3) {
                PorcentajeDescuento = 1.10;
                ValorDescuento = ValorUnitario- (ValorUnitario / PorcentajeDescuento);
                ValorAntes = ValorUnitario;
            }
          if (CanatidadDias < 1 || ValorUnitario <0 )
          
            {
                Error = "El dato ingresado es incorrecto";
            }
           
        }
        }
        #endregion
    }

