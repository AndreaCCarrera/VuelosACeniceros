namespace VuelosACeniceros.Cliente
{
    partial class CambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContrasena));
            this.lbNueva = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.lbRepite = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.txtRepite = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtAntigua = new System.Windows.Forms.TextBox();
            this.lbAntigua = new System.Windows.Forms.Label();
            this.picOjo = new System.Windows.Forms.PictureBox();
            this.lbAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOjo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNueva
            // 
            this.lbNueva.AutoSize = true;
            this.lbNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNueva.Location = new System.Drawing.Point(63, 133);
            this.lbNueva.Name = "lbNueva";
            this.lbNueva.Size = new System.Drawing.Size(151, 16);
            this.lbNueva.TabIndex = 0;
            this.lbNueva.Text = "NUEVA CONTRASEÑA";
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Location = new System.Drawing.Point(198, 250);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(119, 40);
            this.btActualizar.TabIndex = 1;
            this.btActualizar.Text = "ACTUALIZAR";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // lbRepite
            // 
            this.lbRepite.AutoSize = true;
            this.lbRepite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepite.Location = new System.Drawing.Point(63, 173);
            this.lbRepite.Name = "lbRepite";
            this.lbRepite.Size = new System.Drawing.Size(203, 16);
            this.lbRepite.TabIndex = 2;
            this.lbRepite.Text = "REPITE NUEVA CONTRASEÑA";
            // 
            // txtNueva
            // 
            this.txtNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueva.Location = new System.Drawing.Point(273, 130);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(180, 22);
            this.txtNueva.TabIndex = 3;
            this.txtNueva.TextChanged += new System.EventHandler(this.NewTextChange);
            // 
            // txtRepite
            // 
            this.txtRepite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepite.Location = new System.Drawing.Point(273, 170);
            this.txtRepite.Name = "txtRepite";
            this.txtRepite.PasswordChar = '*';
            this.txtRepite.Size = new System.Drawing.Size(180, 22);
            this.txtRepite.TabIndex = 4;
            this.txtRepite.TextChanged += new System.EventHandler(this.NewTextChange);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Location = new System.Drawing.Point(72, 26);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(106, 16);
            this.lbTitulo.TabIndex = 9;
            this.lbTitulo.Text = "vuelosAC.com";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(63, 50);
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // txtAntigua
            // 
            this.txtAntigua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntigua.Location = new System.Drawing.Point(273, 93);
            this.txtAntigua.Name = "txtAntigua";
            this.txtAntigua.PasswordChar = '*';
            this.txtAntigua.Size = new System.Drawing.Size(180, 22);
            this.txtAntigua.TabIndex = 11;
            // 
            // lbAntigua
            // 
            this.lbAntigua.AutoSize = true;
            this.lbAntigua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAntigua.Location = new System.Drawing.Point(63, 96);
            this.lbAntigua.Name = "lbAntigua";
            this.lbAntigua.Size = new System.Drawing.Size(164, 16);
            this.lbAntigua.TabIndex = 10;
            this.lbAntigua.Text = "ANTIGUA CONTRASEÑA";
            // 
            // picOjo
            // 
            this.picOjo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOjo.BackgroundImage")));
            this.picOjo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOjo.Location = new System.Drawing.Point(459, 90);
            this.picOjo.Name = "picOjo";
            this.picOjo.Size = new System.Drawing.Size(35, 29);
            this.picOjo.TabIndex = 12;
            this.picOjo.TabStop = false;
            this.picOjo.Click += new System.EventHandler(this.Ojo_Click);
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAviso.Location = new System.Drawing.Point(72, 218);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(46, 16);
            this.lbAviso.TabIndex = 13;
            this.lbAviso.Text = "Aviso";
            this.lbAviso.Visible = false;
            // 
            // CambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(512, 311);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.picOjo);
            this.Controls.Add(this.txtAntigua);
            this.Controls.Add(this.lbAntigua);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtRepite);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.lbRepite);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.lbNueva);
            this.Name = "CambiarContrasena";
            this.Text = "CambiarContrasena";
            this.Click += new System.EventHandler(this.CambiarContrasena_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOjo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNueva;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Label lbRepite;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.TextBox txtRepite;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtAntigua;
        private System.Windows.Forms.Label lbAntigua;
        private System.Windows.Forms.PictureBox picOjo;
        private System.Windows.Forms.Label lbAviso;
    }
}