
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
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
            this.panelBotones = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.PanelAgregar.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCodigo.Location = new System.Drawing.Point(50, 46);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.IndianRed;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(25, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(117, 45);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(111, 20);
            this.txtbCodigo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtbCodigo, "Ingrese el codigo.. ");
            this.txtbCodigo.TextChanged += new System.EventHandler(this.txtbCodigo_TextChanged);
            // 
            // pboxImagen
            // 
            this.pboxImagen.BackColor = System.Drawing.Color.LightCoral;
            this.pboxImagen.Location = new System.Drawing.Point(333, 65);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(328, 384);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 3;
            this.pboxImagen.TabStop = false;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(117, 249);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(111, 21);
            this.cboxMarca.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboxMarca, "Seleccione una marca..");
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(176, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Location = new System.Drawing.Point(46, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 141);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 16);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Imagen Url: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMarca.Location = new System.Drawing.Point(50, 250);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 16);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca: ";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(117, 94);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(111, 20);
            this.txtbNombre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtbNombre, "Ingrese el nombre del articulo..");
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(117, 141);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(111, 20);
            this.txtbDescripcion.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtbDescripcion, "Ingrese una breve descripcion..");
            this.txtbDescripcion.TextChanged += new System.EventHandler(this.txtbDescripcion_TextChanged);
            // 
            // txtbUrlImagen
            // 
            this.txtbUrlImagen.Location = new System.Drawing.Point(117, 198);
            this.txtbUrlImagen.Name = "txtbUrlImagen";
            this.txtbUrlImagen.Size = new System.Drawing.Size(111, 20);
            this.txtbUrlImagen.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtbUrlImagen, "Ingrese la url...");
            this.txtbUrlImagen.TextChanged += new System.EventHandler(this.txtbUrlImagen_TextChanged);
            this.txtbUrlImagen.Leave += new System.EventHandler(this.txtbUrlImagen_Leave);
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(117, 301);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(111, 21);
            this.cboxCategoria.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboxCategoria, "Seleccione una categoria...");
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCategoria.Location = new System.Drawing.Point(36, 302);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 16);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrecio.Location = new System.Drawing.Point(50, 349);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 16);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio: ";
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Location = new System.Drawing.Point(117, 348);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(111, 20);
            this.txtbPrecio.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtbPrecio, "Ingrese el precio...");
            this.txtbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPrecio_KeyPress);
            this.txtbPrecio.Leave += new System.EventHandler(this.txtbPrecio_Leave);
            // 
            // PanelAgregar
            // 
            this.PanelAgregar.BackColor = System.Drawing.Color.LightCoral;
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
            this.PanelAgregar.Size = new System.Drawing.Size(285, 422);
            this.PanelAgregar.TabIndex = 17;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.LightCoral;
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Location = new System.Drawing.Point(33, 478);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(285, 46);
            this.panelBotones.TabIndex = 18;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Maroon;
            this.progressBar.ForeColor = System.Drawing.Color.IndianRed;
            this.progressBar.Location = new System.Drawing.Point(448, 487);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(102, 30);
            this.progressBar.TabIndex = 19;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.IndianRed;
            this.lblPorcentaje.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPorcentaje.Location = new System.Drawing.Point(489, 496);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(21, 13);
            this.lblPorcentaje.TabIndex = 20;
            this.lblPorcentaje.Text = "0%";
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(683, 573);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.PanelAgregar);
            this.Controls.Add(this.pboxImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.PanelAgregar.ResumeLayout(false);
            this.PanelAgregar.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}