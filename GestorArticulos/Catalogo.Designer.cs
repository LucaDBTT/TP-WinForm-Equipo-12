
namespace GestorArticulos
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtboxBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltroEspecifico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(199, 63);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(552, 318);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(196, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bienvenido al catalogo!";
            // 
            // txtboxBuscar
            // 
            this.txtboxBuscar.Location = new System.Drawing.Point(389, 19);
            this.txtboxBuscar.Name = "txtboxBuscar";
            this.txtboxBuscar.Size = new System.Drawing.Size(362, 20);
            this.txtboxBuscar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtboxBuscar, "Busque un articulo...");
            this.txtboxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBuscar_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(230, 398);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(337, 19);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(46, 13);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(413, 398);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnELiminar
            // 
            this.btnELiminar.Location = new System.Drawing.Point(600, 398);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(75, 23);
            this.btnELiminar.TabIndex = 7;
            this.btnELiminar.Text = "Eliminar";
            this.btnELiminar.UseVisualStyleBackColor = true;
            this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(24, 252);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(121, 20);
            this.txtFiltro.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtFiltro, "Busque un articulo...");
            // 
            // pboxImagen
            // 
            this.pboxImagen.Location = new System.Drawing.Point(784, 63);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(406, 318);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 5;
            this.pboxImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.cboxCriterio);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.cboxCampo);
            this.panel1.Controls.Add(this.lblFiltroEspecifico);
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 526);
            this.panel1.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(49, 327);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(24, 175);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboxCriterio.TabIndex = 7;
            // 
            // cboxCampo
            // 
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(24, 86);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(121, 21);
            this.cboxCampo.TabIndex = 6;
            // 
            // lblFiltroEspecifico
            // 
            this.lblFiltroEspecifico.AutoSize = true;
            this.lblFiltroEspecifico.Location = new System.Drawing.Point(61, 26);
            this.lblFiltroEspecifico.Name = "lblFiltroEspecifico";
            this.lblFiltroEspecifico.Size = new System.Drawing.Size(35, 13);
            this.lblFiltroEspecifico.TabIndex = 5;
            this.lblFiltroEspecifico.Text = "Filtrar ";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1247, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnELiminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pboxImagen);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtboxBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvArticulo);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtboxBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnELiminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.Label lblFiltroEspecifico;
    }
}

