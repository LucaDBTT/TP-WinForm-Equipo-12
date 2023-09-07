using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestorArticulos
{
    class AccesoDatos
    {
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader Lector;

        public AccesoDatos()
        {
            Conexion = new SqlConnection("");
            Comando = new SqlCommand();
        }

        public void SetearQuery(string Query)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Query;
        }

        public void CerrarConexion()
        {
            if(Lector != null) { 
                Lector.Close();
                Conexion.Close();
            }           
        }

        public void EjecutarLectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
