using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libProgramacionSoftware.ClasesBasicas
{
    public class clcTallerP2
    {

        #region Constructor

        public clcTallerP2(){
            ValorPortátiles =1600000;
            ValorTodoUno =2100000;
            ValorMemoria  =125000;
            ValorEquipoJuego =3500000;
           ValorDiscoDuro =300000;
            ValorMouseTecladoIn= 85000;
        }


        #endregion
        #region Propiedades/Atributos
        public double ValorAccesorios { get; private set; }
         public double ValorEquipos { get; private set; }
        public String TipoAcesorio { set; private get; }
        public String TipoEquipo { set; private get; }
        public double SubTotal { private set; get; }
        public double Iva { private set; get; }
        public double Total { private set; get; }
        public string Error { private set; get; }
        public double PorcentajeIva{ private set; get; }
        private double ValorPortátiles;
        private double ValorTodoUno;
        private double ValorEquipoJuego;
	private double ValorDiscoDuro;
        private double ValorMouseTecladoIn;
   private double ValorMemoria;
        public bool DiscoDuro { private get; set; }
        public bool MouseTeclado { private get; set; }
        public bool Memoria { private get; set; }

        #endregion

        #region
        public void CalcuclarTotal()

        {
            Total = ValorAccesorios + ValorEquipos;
            CalcularSubtotal();
            CalcularValorIVA();
            CalcularPrecioEquipo();
            CalcularValorAccesorios();

        }

        private void CalcularSubtotal()
        {
            SubTotal = Total / (1 + PorcentajeIva);
        }
        private void CalcularValorIVA()
        {
            Iva = Total - SubTotal;
        }
        private bool CalcularPrecioEquipo()
        {
            switch (TipoEquipo.ToUpper())
            {
                case "Portatil":
                    PorcentajeIva  = 1;
                    ValorEquipos = ValorPortátiles;
                    return true;
                case "Todo En Uno":
                   PorcentajeIva= 0.08;
                    ValorEquipos = ValorTodoUno;
                    return true;
                case "PC Gamer":
                  PorcentajeIva = 0.19;
                    ValorEquipos = ValorEquipoJuego;
                    return true;
                default:
                    Error = "No definió un tipo de enfermedad aceptado por la EPS";
                    return false;
            }

        }
        public bool CalcularValorAccesorios()
        {

           
            if (DiscoDuro)
            {
                ValorAccesorios += ValorDiscoDuro;
            }
            if (MouseTeclado)
            {
                ValorAccesorios += ValorMouseTecladoIn;
            }
            if (Memoria)
            {
                ValorAccesorios += ValorMemoria;
            }
            return true;
        }
        #endregion
    }
}
