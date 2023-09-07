using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorArticulos
{
    public partial class frmPresentacion : Form
    {
        public frmPresentacion()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {

            this.Hide(); 

            
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.FormClosed += (s, args) => { this.Close(); };
            catalogo.Show();



          
        }
    }
}
