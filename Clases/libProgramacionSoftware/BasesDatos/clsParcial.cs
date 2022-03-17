using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libComunes.CapaDatos;

namespace libProgramacionSoftware.BaseDatos
{
     public class clsParcial
    {

        #region Propiedades/Atributos


        public string Codigo { get; set; }

        public Int64 ValorApartamento { get;  set; }
        public Int64 NumMetrosCuadrados { get;  set; }
        public Int64 ValorMetroCuadrado { get;  set; }
        public string TipoApartamento { get; set; }
        public string Error { get; private set; }

        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        private string SQL;

        #endregion

        #region Metodos 


        public bool Insertar()
        {
            CalcularPrecio();
            SQL = "INSERT INTO CLIENTES (CEDULA, NOMBRE, FECHAVISITA, TIPOAPARTAMENTO, NUMMETROSCUADRADOS, VALORAPARTAMENTO) " +
                  "VALUES (@CEDULA, @NOMBRE, @FECHAVISITA, @TIPOAPARTAMENTO, @NUMMETROSCUADRADOS, @VALORAPARTAMENTO)";

            clsConexion oConexion = new clsConexion();

            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@CEDULA", Cedula);
            oConexion.AgregarParametro("@NOMBRE", Nombre);
            oConexion.AgregarParametro("@FECHAVISITA", Fecha);
            oConexion.AgregarParametro("@TIPOAPARTAMENTO", TipoApartamento);
            oConexion.AgregarParametro("@NUMMETROSCUADRADOS", NumMetrosCuadrados);
            oConexion.AgregarParametro("@VALORAPARTAMENTO", ValorApartamento);




            if (oConexion.EjecutarSentencia())
            {
                return true;
            }
            else
            {
                Error = oConexion.Error;
                return false;
            }
        }





        public bool Actualizar()
        {
            CalcularPrecio();
            SQL = "UPDATE       CLIENTES " +
            "SET                CEDULA=@CEDULA, " +
                               "NOMBRE =@NOMBRE, " +
                               "FECHAVISITA=@FECHAVISITA, " +
                               "TIPOAPARTAMENTO=@TIPOAPARTAMENTO, " +
                               "NUMMETROSCUADRADOS=@NUMMETROSCUADRADOS, " +
                               "VALORAPARTAMENTO=@VALORAPARTAMENTO " +
                 "WHERE         CODIGO=@CODIGO";

            clsConexion oConexion = new clsConexion();

            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@CEDULA", Cedula);
            oConexion.AgregarParametro("@NOMBRE", Nombre);
            oConexion.AgregarParametro("@FECHAVISITA", Fecha);
            oConexion.AgregarParametro("@TIPOAPARTAMENTO", TipoApartamento);
            oConexion.AgregarParametro("@NUMMETROSCUADRADOS", NumMetrosCuadrados);
            oConexion.AgregarParametro("@VALORAPARTAMENTO", ValorApartamento);
            oConexion.AgregarParametro("@CODIGO", Codigo);


            if (oConexion.EjecutarSentencia())
            {
                return true;
            }
            else
            {
                Error = oConexion.Error;
                return false;
            }
        }


        public bool Eliminar()
        {
            SQL = "DELETE FROM CLIENTES WHERE CODIGO=@CODIGO";

            clsConexion oConexion = new clsConexion();

            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@CODIGO", Codigo);

            if (oConexion.EjecutarSentencia())
            {
                return true;
            }
            else
            {
                Error = oConexion.Error;
                return false;
            }
        }



        public bool Consultar()
        {

            SQL = " SELECT      CEDULA, NOMBRE, isnull(FECHAVISITA, '1900/01/01') as FECHAVISITA, TIPOAPARTAMENTO, NUMMETROSCUADRADOS, VALORAPARTAMENTO " +
                  " FROM         CLIENTES " +
                  " WHERE        CODIGO=@CODIGO";

            clsConexion oConexion = new clsConexion();

            oConexion.SQL = SQL;
            oConexion.AgregarParametro("@CODIGO", Codigo);

            if (oConexion.Consultar())
            {
                if (oConexion.Reader.HasRows)
                {
                    oConexion.Reader.Read();
                    Cedula = oConexion.Reader.GetString(0);
                    Nombre = oConexion.Reader.GetString(1);
                    Fecha = oConexion.Reader.GetDateTime(2);
                    TipoApartamento = oConexion.Reader.GetString(3);
                    NumMetrosCuadrados = oConexion.Reader.GetInt64(4);
                    ValorApartamento = oConexion.Reader.GetInt64(5);
                  

                    oConexion.CerrarConexion();
                    return true;
                }
                else
                {
                    Error = "No existen datos para el cliente de codigo: " + Codigo;
                    return false;
                }
            }
            else
            {
                Error = oConexion.Error;
                return false;
            }
        }







        private bool CalcularPrecio()
        {
            if (validar()) {
                switch (TipoApartamento.ToUpper())
                {
                    case "DUPLEX":

                        ValorMetroCuadrado = 5500000;
                        ValorApartamento = NumMetrosCuadrados * ValorMetroCuadrado;
                        return true;
                    case "APARTA ESTUDIO":
                        ValorMetroCuadrado = 5500000;
                        ValorApartamento = NumMetrosCuadrados * ValorMetroCuadrado;

                        return true;
                    case "PENTHOUSE":
                        ValorMetroCuadrado = 7000000;
                        ValorApartamento = NumMetrosCuadrados * ValorMetroCuadrado;

                        return true;

                    default:
                        Error = "No definio un consumo valido";
                        return false;

                    case "OTRO":

                        ValorMetroCuadrado = 5500000;
                        ValorApartamento = NumMetrosCuadrados * ValorMetroCuadrado;
                        return true;

                }
                return true;
                    
                    }
            else {
                return false;
            }
        

        }

        private bool validar() {
            if (NumMetrosCuadrados <= 0) {
                Error = "debes ingresar un valor valido para lo metros cuadrados";
                return false;
                    }
            else {

                return true;
            }
        
        }


        #endregion






    }
}
