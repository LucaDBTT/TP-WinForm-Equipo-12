
namespace GestorArticulos
{
    partial class frmPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacion));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lblPrecionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Firebrick;
            this.lblBienvenida.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBienvenida.Location = new System.Drawing.Point(124, 88);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(501, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenidos al catalogo de articulos!";
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Firebrick;
            this.btnComenzar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnComenzar.Location = new System.Drawing.Point(327, 176);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Gestionar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // lblPrecionar
            // 
            this.lblPrecionar.AutoSize = true;
            this.lblPrecionar.BackColor = System.Drawing.Color.Firebrick;
            this.lblPrecionar.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecionar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrecionar.Location = new System.Drawing.Point(198, 137);
            this.lblPrecionar.Name = "lblPrecionar";
            this.lblPrecionar.Size = new System.Drawing.Size(336, 23);
            this.lblPrecionar.TabIndex = 2;
            this.lblPrecionar.Text = "Precione el boton para continuar..";
            // 
            // frmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.lblPrecionar);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblBienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lblPrecionar;
    }
}