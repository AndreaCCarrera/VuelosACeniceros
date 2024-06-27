namespace VuelosACeniceros.Cliente
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            this.btComprar = new System.Windows.Forms.Button();
            this.groupVuelo = new System.Windows.Forms.GroupBox();
            this.lbAviso = new System.Windows.Forms.Label();
            this.txtVuelo = new System.Windows.Forms.TextBox();
            this.btVerVuelo = new System.Windows.Forms.Button();
            this.btHistorico = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupVuelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btComprar
            // 
            this.btComprar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.Location = new System.Drawing.Point(61, 106);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(234, 48);
            this.btComprar.TabIndex = 0;
            this.btComprar.Text = "COMPRAR BILLETE";
            this.btComprar.UseVisualStyleBackColor = false;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // groupVuelo
            // 
            this.groupVuelo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupVuelo.Controls.Add(this.lbAviso);
            this.groupVuelo.Controls.Add(this.txtVuelo);
            this.groupVuelo.Controls.Add(this.btVerVuelo);
            this.groupVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVuelo.Location = new System.Drawing.Point(61, 170);
            this.groupVuelo.Name = "groupVuelo";
            this.groupVuelo.Size = new System.Drawing.Size(234, 149);
            this.groupVuelo.TabIndex = 1;
            this.groupVuelo.TabStop = false;
            this.groupVuelo.Text = "MI VUELO";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAviso.Location = new System.Drawing.Point(18, 121);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(46, 16);
            this.lbAviso.TabIndex = 8;
            this.lbAviso.Text = "Aviso";
            this.lbAviso.Visible = false;
            // 
            // txtVuelo
            // 
            this.txtVuelo.Location = new System.Drawing.Point(45, 85);
            this.txtVuelo.Name = "txtVuelo";
            this.txtVuelo.Size = new System.Drawing.Size(136, 22);
            this.txtVuelo.TabIndex = 1;
            this.txtVuelo.TextChanged += new System.EventHandler(this.txtVuelo_TextChanged);
            this.txtVuelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // btVerVuelo
            // 
            this.btVerVuelo.Location = new System.Drawing.Point(45, 47);
            this.btVerVuelo.Name = "btVerVuelo";
            this.btVerVuelo.Size = new System.Drawing.Size(136, 23);
            this.btVerVuelo.TabIndex = 0;
            this.btVerVuelo.Text = "VER MI VUELO";
            this.btVerVuelo.UseVisualStyleBackColor = true;
            this.btVerVuelo.Click += new System.EventHandler(this.btVerVuelo_Click);
            // 
            // btHistorico
            // 
            this.btHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.Location = new System.Drawing.Point(61, 335);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(234, 32);
            this.btHistorico.TabIndex = 2;
            this.btHistorico.Text = "VER HISTORICO";
            this.btHistorico.UseVisualStyleBackColor = true;
            this.btHistorico.Click += new System.EventHandler(this.btHistorico_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSalir.Location = new System.Drawing.Point(61, 394);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(234, 42);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(31, 76);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(48, 16);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "Hola, ";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(1, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 56);
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Location = new System.Drawing.Point(43, 42);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(106, 16);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "vuelosAC.com";
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 467);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.groupVuelo);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.picLogo);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.Click += new System.EventHandler(this.MenuCliente_Click);
            this.groupVuelo.ResumeLayout(false);
            this.groupVuelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.GroupBox groupVuelo;
        private System.Windows.Forms.Button btVerVuelo;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox txtVuelo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbAviso;
    }
}