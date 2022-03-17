using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libDesarrolloSoftware.Taller
{
    public class clsVentaAccesorios
    {
        public clsVentaAccesorios()
        {
            ValorDiscoDuro = 300000;
            ValorMouseTeclado = 85000;
            ValorMemoria = 125000;
        }
        #region Propiedades/Atributos
        public bool DiscoDuro { private get; set; }
        public bool MouseTeclado { private get; set; }
        public bool Memoria { private get; set; }
        public Int32 ValorAccesorios { get; private set; }
        private Int32 ValorDiscoDuro;
        private int ValorMouseTeclado;
        private int ValorMemoria;
        public string Error { get; private set; }
        #endregion
        #region Metodos
        public bool CalcularValorAccesorios()
        {
            ValorAccesorios = 0;
            if (DiscoDuro)
            {
                ValorAccesorios += ValorDiscoDuro;
            }
            if (MouseTeclado)
            {
                ValorAccesorios += ValorMouseTeclado;
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
