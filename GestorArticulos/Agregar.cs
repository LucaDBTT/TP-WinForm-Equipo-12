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
        public frmAgregar()
        {
            InitializeComponent();
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
                cboxMarca.DataSource = marca.ListarMarcas();


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
            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                articulo.CodigoArticulo = txtbCodigo.Text;
                articulo.Nombre = txtbNombre.Text;
                articulo.Descripcion = txtbDescripcion.Text;
                articulo.Precio = decimal.Parse(txtbPrecio.Text);
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                articulo.ImagenUrl = new Imagen();
                articulo.ImagenUrl.Descripcion = txtbUrlImagen.Text;

                articuloNegocio.Agregar(articulo);
                
                MessageBox.Show("Agregado correctamente!");
                Close();
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void txtbUrlImagen_Leave(object sender, EventArgs e)
        {
            string url = txtbUrlImagen.Text.Trim();

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
    }
}
