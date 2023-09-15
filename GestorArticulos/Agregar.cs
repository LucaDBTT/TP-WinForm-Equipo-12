using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;


namespace GestorArticulos
{
    public partial class frmAgregar : Form
    {
        private Articulo Articulo = null;
        public frmAgregar()
        {
            InitializeComponent();

        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo;
            Text = "Modificar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void cargar()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cboxCategoria.DataSource = categoria.ListarCategorias();
                cboxCategoria.ValueMember = "IdCategoria";
                cboxCategoria.DisplayMember = "Descripcion";
                cboxMarca.DataSource = marca.ListarMarcas();
                cboxMarca.ValueMember = "IdMarca";
                cboxMarca.DisplayMember = "Descripcion";

                if(Articulo != null )
                {
                    txtbCodigo.Text = Articulo.CodigoArticulo;
                    txtbNombre.Text = Articulo.Nombre;
                    txtbDescripcion.Text = Articulo.Descripcion;
                    txtbPrecio.Text = Articulo.Precio.ToString();
                    ImagenAddChange(Articulo.ImagenUrl.Descripcion);
                    txtbUrlImagen.Text = Articulo.ImagenUrl.Descripcion;
                    if (Articulo.Categoria != null)
                    {
                        if (Articulo.Categoria.Descripcion == null)
                        {
                            cboxCategoria.SelectedValue = -1;
                        }
                        else
                        {
                            cboxCategoria.SelectedValue = Articulo.Categoria.IdCategoria;
                        }
                    }
                    else
                    {
                        cboxCategoria.SelectedValue = -1;
                    }

                    cboxMarca.SelectedValue = Articulo.Marca.IdMarca; 

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }


        private void frmAgregar_Load(object sender, EventArgs e)
        {
            cargar();
        }
       
      
        private void btnAgregar_Click(object sender, EventArgs e)
        {      
            
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (Articulo == null)
                {
                    Articulo = new Articulo();
                }

                Articulo.CodigoArticulo = txtbCodigo.Text;
                Articulo.Nombre = txtbNombre.Text;
                Articulo.Descripcion = txtbDescripcion.Text;
                Articulo.Precio = decimal.Parse(txtbPrecio.Text);
                Articulo.Marca = (Marca)cboxMarca.SelectedItem;
                Articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                Articulo.ImagenUrl = new Imagen();
                Articulo.ImagenUrl.Descripcion = txtbUrlImagen.Text;
            
                if(Articulo.IdArticulo != 0)
                {
                    articuloNegocio.Modificar(Articulo);
                    MessageBox.Show("Modificado correctamente!");
                }
                else
                {
                    articuloNegocio.Agregar(Articulo);
                    MessageBox.Show("Agregado correctamente!");
                }
                Close();
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ImagenAddChange(string url)
        {

            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    pboxImagen.Load(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pboxImagen.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }

        }

        private void txtbUrlImagen_Leave(object sender, EventArgs e)
        {
            string url = txtbUrlImagen.Text.Trim();
            ImagenAddChange(url);

        }
    }
}
