using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace GestorArticulos
{
    public partial class frmCatalogo : Form
    {
        private List<Articulo> ListaArticulos;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            Cargar();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        public void Cargar ()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                this.BackgroundImage = Properties.Resources.presentacionWF1;
                ListaArticulos = negocio.ListarArticulos();
                dgvArticulo.DataSource = ListaArticulos;
                dgvArticulo.Columns["ImagenUrl"].Visible = false;
                cargarImagen(ListaArticulos[0].ImagenUrl.Descripcion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            string url = seleccionado.ImagenUrl.Descripcion;
            cargarImagen(url);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pboxImagen.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.bajaFisica(seleccionado.IdArticulo);
            Cargar();
        }
    }
}
