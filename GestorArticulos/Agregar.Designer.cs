
namespace GestorArticulos
{
    partial class frmAgregar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbUrlImagen = new System.Windows.Forms.TextBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PanelAgregar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.PanelAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(53, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(57, 469);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(117, 35);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(111, 20);
            this.txtbCodigo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtbCodigo, "Ingrese el codigo.. ");
            // 
            // pboxImagen
            // 
            this.pboxImagen.Location = new System.Drawing.Point(343, 40);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(328, 359);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 3;
            this.pboxImagen.TabStop = false;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(117, 245);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(111, 21);
            this.cboxMarca.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboxMarca, "Seleccione una marca..");
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(188, 469);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(53, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 140);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Imagen Url: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(56, 253);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca: ";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(117, 83);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(111, 20);
            this.txtbNombre.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtbNombre, "Ingrese el nombre del articulo..");
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(117, 133);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(111, 20);
            this.txtbDescripcion.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtbDescripcion, "Ingrese una breve descripcion..");
            // 
            // txtbUrlImagen
            // 
            this.txtbUrlImagen.Location = new System.Drawing.Point(117, 190);
            this.txtbUrlImagen.Name = "txtbUrlImagen";
            this.txtbUrlImagen.Size = new System.Drawing.Size(111, 20);
            this.txtbUrlImagen.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtbUrlImagen, "Ingrese la url...");
            this.txtbUrlImagen.Leave += new System.EventHandler(this.txtbUrlImagen_Leave);
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(117, 297);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(111, 21);
            this.cboxCategoria.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cboxCategoria, "Seleccione una categoria...");
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(45, 305);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(53, 351);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio: ";
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Location = new System.Drawing.Point(117, 344);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(111, 20);
            this.txtbPrecio.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtbPrecio, "Ingrese el precio...");
            // 
            // PanelAgregar
            // 
            this.PanelAgregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelAgregar.Controls.Add(this.txtbNombre);
            this.PanelAgregar.Controls.Add(this.txtbPrecio);
            this.PanelAgregar.Controls.Add(this.lblCodigo);
            this.PanelAgregar.Controls.Add(this.lblPrecio);
            this.PanelAgregar.Controls.Add(this.txtbCodigo);
            this.PanelAgregar.Controls.Add(this.lblCategoria);
            this.PanelAgregar.Controls.Add(this.cboxMarca);
            this.PanelAgregar.Controls.Add(this.cboxCategoria);
            this.PanelAgregar.Controls.Add(this.lblNombre);
            this.PanelAgregar.Controls.Add(this.txtbUrlImagen);
            this.PanelAgregar.Controls.Add(this.lblDescripcion);
            this.PanelAgregar.Controls.Add(this.txtbDescripcion);
            this.PanelAgregar.Controls.Add(this.label4);
            this.PanelAgregar.Controls.Add(this.lblMarca);
            this.PanelAgregar.Location = new System.Drawing.Point(33, 40);
            this.PanelAgregar.Name = "PanelAgregar";
            this.PanelAgregar.Size = new System.Drawing.Size(285, 412);
            this.PanelAgregar.TabIndex = 17;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 521);
            this.Controls.Add(this.PanelAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pboxImagen);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.PanelAgregar.ResumeLayout(false);
            this.PanelAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbUrlImagen;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.Panel PanelAgregar;
    }
}