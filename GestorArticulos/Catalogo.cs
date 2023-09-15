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
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
        }
        public void Cargar ()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                this.BackgroundImage = Properties.Resources.presentacionWF1;
                ListaArticulos = negocio.ListarArticulos();
                dgvArticulo.DataSource = ListaArticulos;
                ocultarImagen();
                cargarImagen(ListaArticulos[0].ImagenUrl.Descripcion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void ocultarImagen()
        {
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["IdArticulo"].Visible = false;
        }
        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            string url = seleccionado.ImagenUrl.Descripcion;
            cargarImagen(url);
        }

        public void cargarImagen(string imagen)
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

        private void txtboxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaFiltrada;

            if (txtboxBuscar.Text == "")
            {
                listaFiltrada = ListaArticulos;
            }
            else
            {
                listaFiltrada = ListaArticulos.FindAll(k =>
                {
                    return (k.Nombre != null && k.Nombre.ToLower().Contains(txtboxBuscar.Text.ToLower())) ||
                           (k.Descripcion != null && k.Descripcion.ToLower().Contains(txtboxBuscar.Text.ToLower())) ||
                           (k.CodigoArticulo != null && k.CodigoArticulo.ToLower().Contains(txtboxBuscar.Text.ToLower())) ||
                           (k.Marca != null && k.Marca.Descripcion != null && k.Marca.Descripcion.ToLower().Contains(txtboxBuscar.Text.ToLower())) ||
                           (k.Categoria != null && k.Categoria.Descripcion != null && k.Categoria.Descripcion.ToLower().Contains(txtboxBuscar.Text.ToLower()));
                });
            }
            dgvArticulo.DataSource = listaFiltrada;
            ocultarImagen();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cboCampo.SelectedItem.ToString();
            if (opcionSeleccionada == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Precio menor a: ");
                cboCriterio.Items.Add("Precio mayor a: ");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Contiene las letras: ");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            Cargar(); 
        }
    }
}
