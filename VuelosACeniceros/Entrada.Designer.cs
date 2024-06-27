namespace VuelosACeniceros
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.lbDni = new System.Windows.Forms.Label();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.picOjo = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOjo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(226, 70);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(75, 16);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "USUARIO";
            // 
            // lbContrasena
            // 
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasena.Location = new System.Drawing.Point(218, 120);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(98, 15);
            this.lbContrasena.TabIndex = 1;
            this.lbContrasena.Text = "CONTRASEÑA";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(334, 67);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(185, 22);
            this.txtDni.TabIndex = 2;
            this.txtDni.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(334, 119);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(185, 22);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.btEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.Location = new System.Drawing.Point(216, 197);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(303, 37);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "ENTRAR";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // picOjo
            // 
            this.picOjo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOjo.BackgroundImage")));
            this.picOjo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOjo.Location = new System.Drawing.Point(525, 114);
            this.picOjo.Name = "picOjo";
            this.picOjo.Size = new System.Drawing.Size(35, 29);
            this.picOjo.TabIndex = 5;
            this.picOjo.TabStop = false;
            this.picOjo.Click += new System.EventHandler(this.Ojo_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Location = new System.Drawing.Point(39, 230);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(122, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "vuelosAC.com";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAviso.Location = new System.Drawing.Point(226, 169);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(46, 16);
            this.lbAviso.TabIndex = 7;
            this.lbAviso.Text = "Aviso";
            this.lbAviso.Visible = false;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(578, 291);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.picOjo);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lbContrasena);
            this.Controls.Add(this.lbDni);
            this.DoubleBuffered = true;
            this.Name = "Entrada";
            this.Text = "Acceso";
            this.Click += new System.EventHandler(this.Entrada_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picOjo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.PictureBox picOjo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbAviso;
    }
}