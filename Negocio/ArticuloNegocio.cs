using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List <Articulo> Listar()
        {
              List<Articulo> Lista = new List<Articulo>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("");
                Datos.EjecutarLectura();
                while (Datos.lector.Read())
                {
                    
                }
                return Lista;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("");
                Datos.EjecutarLectura();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
        public void Modificar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("");
                datos.EjecutarLectura();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void Eliminar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("");
                datos.EjecutarLectura();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

    }
}
