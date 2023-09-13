using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarImagenes()
        {
            List<Imagen> Lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select  IdArticulo, ImagenUrl from IMAGENES");
                datos.EjecutarLectura();
                while (datos.lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.IdArticulo = (int)datos.lector["IdArticulo"];

                    aux.Descripcion = (string)datos.lector["ImagenUrl"];

                    Lista.Add(aux);
                }
                return Lista;
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

            public Imagen getIdImagen()
            {
                AccesoDatos datos1 = new AccesoDatos();
                Imagen aux = new Imagen();
                
                try
                {
                    datos1.SetearQuery("SELECT TOP 1 Id FROM ARTICULOS ORDER BY Id DESC");
                    datos1.EjecutarLectura();
                    while (datos1.lector.Read())
                    {

                        aux.IdArticulo = (int)datos1.lector["IdArticulo"];

                    }
                    return aux;
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    datos1.CerrarConexion();
                }
            }
    }
}

