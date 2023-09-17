
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtboxBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.lbCampo = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltroEspecifico = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelFiltroRapido = new System.Windows.Forms.Panel();
            this.lblImagen = new System.Windows.Forms.Label();
            this.ttpAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttpModificar = new System.Windows.Forms.ToolTip(this.components);
            this.ttpEliminar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelFiltroRapido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(196, 142);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(634, 383);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.LightCoral;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(465, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(344, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Catálogo de articulos";
            // 
            // txtboxBuscar
            // 
            this.txtboxBuscar.Location = new System.Drawing.Point(113, 17);
            this.txtboxBuscar.Name = "txtboxBuscar";
            this.txtboxBuscar.Size = new System.Drawing.Size(362, 20);
            this.txtboxBuscar.TabIndex = 2;
            this.txtboxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBuscar_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightCoral;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LightCoral;
            this.btnAgregar.Location = new System.Drawing.Point(57, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 64);
            this.btnAgregar.TabIndex = 3;
            this.ttpAgregar.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBuscar.Location = new System.Drawing.Point(3, 17);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(111, 18);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Filtro rápido : ";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightCoral;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.LightCoral;
            this.btnModificar.Location = new System.Drawing.Point(174, 28);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 64);
            this.btnModificar.TabIndex = 6;
            this.ttpModificar.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnELiminar
            // 
            this.btnELiminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnELiminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnELiminar.BackgroundImage")));
            this.btnELiminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELiminar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELiminar.ForeColor = System.Drawing.Color.LightCoral;
            this.btnELiminar.Location = new System.Drawing.Point(283, 28);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(64, 64);
            this.btnELiminar.TabIndex = 7;
            this.ttpEliminar.SetToolTip(this.btnELiminar, "Eliminar");
            this.btnELiminar.UseVisualStyleBackColor = false;
            this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(24, 310);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(121, 20);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // pboxImagen
            // 
            this.pboxImagen.BackColor = System.Drawing.Color.LightCoral;
            this.pboxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxImagen.Location = new System.Drawing.Point(836, 207);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(406, 318);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 5;
            this.pboxImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbCriterio);
            this.panel1.Controls.Add(this.lbCampo);
            this.panel1.Controls.Add(this.cboCriterio);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.cboCampo);
            this.panel1.Controls.Add(this.lblFiltroEspecifico);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 438);
            this.panel1.TabIndex = 9;
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.ForeColor = System.Drawing.SystemColors.Window;
            this.lbCriterio.Location = new System.Drawing.Point(38, 219);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(100, 13);
            this.lbCriterio.TabIndex = 11;
            this.lbCriterio.Text = "Elija el criterio : ";
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbCampo.Location = new System.Drawing.Point(38, 146);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(96, 13);
            this.lbCampo.TabIndex = 10;
            this.lbCampo.Text = "Elija el campo : ";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(24, 244);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 7;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(24, 172);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 6;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblFiltroEspecifico
            // 
            this.lblFiltroEspecifico.AutoSize = true;
            this.lblFiltroEspecifico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFiltroEspecifico.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEspecifico.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFiltroEspecifico.Location = new System.Drawing.Point(30, 68);
            this.lblFiltroEspecifico.Name = "lblFiltroEspecifico";
            this.lblFiltroEspecifico.Size = new System.Drawing.Size(129, 24);
            this.lblFiltroEspecifico.TabIndex = 5;
            this.lblFiltroEspecifico.Text = "Filtrar por : ";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.LightCoral;
            this.panelBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Controls.Add(this.btnModificar);
            this.panelBotones.Controls.Add(this.btnELiminar);
            this.panelBotones.Location = new System.Drawing.Point(836, 87);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(409, 113);
            this.panelBotones.TabIndex = 10;
            // 
            // panelFiltroRapido
            // 
            this.panelFiltroRapido.BackColor = System.Drawing.Color.LightCoral;
            this.panelFiltroRapido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltroRapido.Controls.Add(this.txtboxBuscar);
            this.panelFiltroRapido.Controls.Add(this.lblBuscar);
            this.panelFiltroRapido.Location = new System.Drawing.Point(196, 87);
            this.panelFiltroRapido.Name = "panelFiltroRapido";
            this.panelFiltroRapido.Size = new System.Drawing.Size(634, 49);
            this.panelFiltroRapido.TabIndex = 11;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.IndianRed;
            this.lblImagen.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.White;
            this.lblImagen.Location = new System.Drawing.Point(1195, 528);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(47, 13);
            this.lblImagen.TabIndex = 12;
            this.lblImagen.Text = "Imagen";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1281, 591);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.panelFiltroRapido);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pboxImagen);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelFiltroRapido.ResumeLayout(false);
            this.panelFiltroRapido.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblFiltroEspecifico;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelFiltroRapido;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ToolTip ttpAgregar;
        private System.Windows.Forms.ToolTip ttpModificar;
        private System.Windows.Forms.ToolTip ttpEliminar;
    }
}

