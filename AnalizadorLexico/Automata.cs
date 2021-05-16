using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AnalizadorLexico
{
    class Automata
    {
        public List<Token> lstTokens = new List<Token>();
        public List<Error> lstErrores = new List<Error>();
        private Estado _EstadoActual;
        public Estado EstadoActual
        {
            get { return _EstadoActual; }
            set { _EstadoActual = value; }
        }

        private string  _strFDC;

        public string  FDC
        {
            get { return _strFDC; }
            set { _strFDC = value; }
        }


        public Automata()
        {
            EstadoActual = new Estado();
            EstadoActual.NumeroEstado = 0.ToString();
            FDC = ";";
        }
        public void BuscarSiguienteEstado(string caracterActual, EjecutorQuerys conexion)
        {
            Token miToken = new Token();
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            da = new SqlDataAdapter("SELECT \"" + caracterActual + "\", CAT FROM Matriz WHERE ESTADOS = " + EstadoActual.NumeroEstado, conexion.Conectar());
            da.Fill(dt);
            EstadoActual.NumeroEstado = dt.Rows[0][caracterActual].ToString();
            miToken.CAT = dt.Rows[0]["CAT"].ToString();
            if (EstadoActual.NumeroEstado.Contains("Error"))
            {
                Error miError = new Error();
                miError.CatError = EstadoActual.NumeroEstado;
                lstErrores.Add(miError);
                EstadoActual.NumeroEstado = 0.ToString();
            }
            else
            {
                if (caracterActual == ";")
                {
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2;
                    da2 = new SqlDataAdapter("SELECT \"" + caracterActual + "\" FROM Matriz WHERE ESTADOS = " + EstadoActual.NumeroEstado, conexion.Conectar());
                    da2.Fill(dt2);
                    FDC = dt2.Rows[0][";"].ToString();
                }
                if (FDC == "Acepta")
                {
                    DataTable dataTable1 = new DataTable();
                    SqlDataAdapter da1;
                    da1 = new SqlDataAdapter("SELECT CAT FROM Matriz WHERE ESTADOS = " + EstadoActual.NumeroEstado, conexion.Conectar());
                    da1.Fill(dataTable1);
                    miToken.CAT = dataTable1.Rows[0]["CAT"].ToString();

                    lstTokens.Add(miToken);
                    EstadoActual.NumeroEstado = 0.ToString();
                    FDC = ";";
                }
            }
        }
    }
}
