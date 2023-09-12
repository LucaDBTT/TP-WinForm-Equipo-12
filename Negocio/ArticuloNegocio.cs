using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List <Articulo> ListarArticulos()
        {
              List<Articulo> Lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio, A.IdCategoria, A.IdMarca, A.Id, I.ImagenUrl from ARTICULOS A, CATEGORIAS C, MARCAS M, Imagenes I where C.Id = A.IdCategoria and M.Id = A.IdMarca and A.Id = I.IdArticulo");
                datos.EjecutarLectura();
                while (datos.lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.IdArticulo = (int)datos.lector["Id"];
                    aux.CodigoArticulo = datos.lector.GetString(0);
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.Precio = (decimal)datos.lector["Precio"];

                    if (!(datos.lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.lector["ImagenUrl"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.lector["Categoria"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.lector["Marca"];


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
    

    }
}
