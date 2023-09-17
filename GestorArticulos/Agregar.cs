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

                if (Articulo != null)
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
            progressBar.Visible = false;
        }

        private bool buscarArticulo(string CodArticulo)
        {
            List<Articulo> articulos = new List<Articulo>();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                articulos=articuloNegocio.ListarArticulos();

                foreach (Articulo item in articulos)
                {
                    if(item.CodigoArticulo == CodArticulo)
                    {
                        return true;
                    }

                }
                return false;

            }

            catch (Exception ex)
            {

                throw ex;
            }
        }


        /* private void btnAgregar_Click(object sender, EventArgs e)
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

                 if (Articulo.IdArticulo != 0)
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
         }*/

        private bool validarCampos()
        {
            if(string.IsNullOrEmpty(txtbCodigo.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(txtbDescripcion.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(txtbUrlImagen.Text))
            {
                return true;
            }
            if (cboxMarca.SelectedIndex < 0)
            {
                return true;
            }
            if (cboxCategoria.SelectedIndex < 0)
            {
                return true;
            }
            if (string.IsNullOrEmpty(txtbPrecio.Text))
            {
                return true;
            }         
            return false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Deshabilita el botón Agregar para evitar acciones adicionales hasta que se complete el proceso.
            btnAgregar.Enabled = false;

            // Define el valor máximo de progreso (en este caso, 70).
            progressBar.Maximum = 100;

            // Inicializa la ProgressBar en 0.
            progressBar.Value = 0;

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            if (validarCampos())
            {
                btnAgregar.Enabled = true; // Habilitar el botón nuevamente.
                MessageBox.Show("Campos incompletos...");
                return; // Salir del método sin guardar el artículo.
            }

            if (buscarArticulo(txtbCodigo.Text))
            {
                MessageBox.Show("El código de Articulo ya existe, agregue otro por favor.");
                btnAgregar.Enabled = true; // Habilitar el botón nuevamente.
                return; // Salir del método sin guardar el artículo.
            }

            try
            {
                
                if (Articulo == null)
                {
                    Articulo = new Articulo();
                }
                progressBar.ForeColor = Color.DarkGray;
                Articulo.CodigoArticulo = txtbCodigo.Text;
                Articulo.Nombre = txtbNombre.Text;

                Articulo.CodigoArticulo = txtbCodigo.Text;

                Articulo.Nombre = txtbNombre.Text;

                Articulo.Descripcion = txtbDescripcion.Text;

                Articulo.Precio = decimal.Parse(txtbPrecio.Text);

                Articulo.Marca = (Marca)cboxMarca.SelectedItem;

                Articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;

                Articulo.ImagenUrl = new Imagen();
                Articulo.ImagenUrl.Descripcion = txtbUrlImagen.Text;

                if (Articulo.IdArticulo != 0)
                {

                    articuloNegocio.Modificar(Articulo);
                    for (int i = 1; i <= 10; i++)
                    {
                        progressBar.Value += 10;
                        if (progressBar.Value == 100)
                        {
                            progressBar.Visible = true;
                            lblPorcentaje.Text = "Modificado!";
                        }
                    }
                    MessageBox.Show("Modificado correctamente!");
                }
                else
                {
                                                               
                    articuloNegocio.Agregar(Articulo);            
                    for (int i = 1; i <= 10; i++)
                    {
                        progressBar.Value += 10;
                        if (progressBar.Value == 100)
                        {
                            progressBar.Visible = true;
                            lblPorcentaje.Text = "Agregado!";
                        }
                    }
                    MessageBox.Show("Agregado correctamente!");   
  
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar/modificar artículo: " + ex.Message);
            }
            finally
            {

                btnAgregar.Enabled = true;
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
                    MessageBox.Show("Imagen rota, por favor modifiquela...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pboxImagen.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
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


        private void txtbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir números, el punto decimal y la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') ||
                (e.KeyChar == '.' && txtbPrecio.Text.Contains('.')))
            {
                e.Handled = true; // Evitar que se escriba el carácter
            }

        }
    }
}
