using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace libDesarrolloSoftware.Taller
{
    public class clsIncapacidades
    {
        #region Propiedades/Atributos
        public string TipoEnfermedad { private get; set; }
        public Int16 DiasIncapacidad { get; private set; }
        public string Error { get; private set; }
        #endregion
        #region Metodos
        public bool CalcularDiasIncapacidad()
        {
            //Se deben calcular con case, que en C# se utiliza la palabra clave: switch
            switch (TipoEnfermedad.ToUpper())//ToUpper convierte el texto a mayúsculas para garantizar la comparación
            {
                case "VIRAL":
                    DiasIncapacidad = 2;
                    return true;
                case "BACTERIAL":
                    DiasIncapacidad = 5;
                    return true;
                case "CIRUGIA MENOR":
                    DiasIncapacidad = 7;
                    return true;
                case "CIRUGIA MAYOR":
                    DiasIncapacidad = 15;
                    return true;
                case "GRIPA":
                    DiasIncapacidad = 0;
                    return true;
                default:
                    Error = "No definió un tipo de enfermedad aceptado por la EPS";
                    return false;
            }
        }
        #endregion
    }
}
