using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                datos.SetearQuery("select a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Descripcion as MarcaDescripcion, c.Descripcion as CategoriaDescripcion, im.ImagenUrl from ARTICULOS a INNER join IMAGENES im ON a.Id= im.IdArticulo INNER JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id");
                datos.EjecutarLectura();
                while (datos.lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.IdArticulo = (int)datos.lector["Id"];
                    aux.CodigoArticulo = (string)datos.lector["Codigo"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.lector["MarcaDescripcion"];
                    aux.Categoria = new Categoria();
                    aux.ImagenUrl = new Imagen();
                    
                    if (datos.lector["CategoriaDescripcion"] is DBNull)
                    {
                        aux.Categoria = null;
                    }
                    else
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.lector["CategoriaDescripcion"];
                    }

                  if (!(datos.lector["ImagenUrl"] is DBNull))
                     aux.ImagenUrl.Descripcion = (string)datos.lector["ImagenUrl"];

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
               // Datos.SetearQuery("insert into ARTICULOS (Codigo, Nombre, Descripcion,Precio) VALUES ("+nuevo.CodigoArticulo+",'"+nuevo.Nombre+"', '"+nuevo.Descripcion+"', "+nuevo.Precio+")\r\ninsert into MARCAS (Descripcion) VALUES ('"+nuevo.Marca.Descripcion+"')\r\ninsert into CATEGORIAS (Descripcion) VALUES ('"+nuevo.Categoria.Descripcion+"')\r\ninsert into IMAGENES (IdArticulo , ImagenUrl) VALUES("+nuevo.ImagenUrl.IdArticulo+",'"+nuevo.ImagenUrl.Descripcion+"')");
                //Datos.EjecutarLectura();
                Datos.ejecutarAccion();
                
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
        public void bajaFisica(int id)
        {
            AccesoDatos datos = new AccesoDatos();
             DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (dialogo == DialogResult.Yes)
                {
                    datos.SetearQuery("delete from ARTICULOS where Id = @id");
                    datos.setearParametros("@id", id);
                    datos.ejecutarAccion();
                    MessageBox.Show("Articulo eliminado con exito");
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


    }
}
