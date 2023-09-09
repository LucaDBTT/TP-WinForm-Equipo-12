
namespace GestorArticulos
{
    partial class form1
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
            this.lblBievenida = new System.Windows.Forms.Label();
            this.lblBotones = new System.Windows.Forms.Label();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBievenida
            // 
            this.lblBievenida.AutoSize = true;
            this.lblBievenida.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBievenida.Location = new System.Drawing.Point(228, 148);
            this.lblBievenida.Name = "lblBievenida";
            this.lblBievenida.Size = new System.Drawing.Size(522, 32);
            this.lblBievenida.TabIndex = 0;
            this.lblBievenida.Text = "Bienvenidos al catalogo del comercio!";
            // 
            // lblBotones
            // 
            this.lblBotones.AutoSize = true;
            this.lblBotones.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotones.Location = new System.Drawing.Point(297, 285);
            this.lblBotones.Name = "lblBotones";
            this.lblBotones.Size = new System.Drawing.Size(373, 25);
            this.lblBotones.TabIndex = 1;
            this.lblBotones.Text = "Presione el boton para continuar ... ";
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(392, 356);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(75, 23);
            this.btnGestionar.TabIndex = 2;
            this.btnGestionar.Text = "Continuar";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(502, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 676);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionar);
            this.Controls.Add(this.lblBotones);
            this.Controls.Add(this.lblBievenida);
            this.Name = "form1";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBievenida;
        private System.Windows.Forms.Label lblBotones;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Button btnSalir;
    }
}

