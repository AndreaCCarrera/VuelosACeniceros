namespace VuelosACeniceros
{
    partial class Comprar2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar2));
            this.datosPersonales = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.datosVuelo = new System.Windows.Forms.GroupBox();
            this.txtVuelta = new System.Windows.Forms.TextBox();
            this.txtIda = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lbVuelta = new System.Windows.Forms.Label();
            this.lbIda = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.btComprar = new System.Windows.Forms.Button();
            this.lbAviso = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datosPersonales.SuspendLayout();
            this.datosVuelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // datosPersonales
            // 
            this.datosPersonales.Controls.Add(this.txtDni);
            this.datosPersonales.Controls.Add(this.txtDireccion);
            this.datosPersonales.Controls.Add(this.txtApellidos);
            this.datosPersonales.Controls.Add(this.txtNombre);
            this.datosPersonales.Controls.Add(this.lbDni);
            this.datosPersonales.Controls.Add(this.lbDireccion);
            this.datosPersonales.Controls.Add(this.lbApellidos);
            this.datosPersonales.Controls.Add(this.lbNombre);
            this.datosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosPersonales.Location = new System.Drawing.Point(43, 83);
            this.datosPersonales.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.datosPersonales.Name = "datosPersonales";
            this.datosPersonales.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.datosPersonales.Size = new System.Drawing.Size(431, 243);
            this.datosPersonales.TabIndex = 0;
            this.datosPersonales.TabStop = false;
            this.datosPersonales.Text = "DATOS PERSONALES";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(106, 173);
            this.txtDni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(278, 22);
            this.txtDni.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(106, 130);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(278, 22);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(106, 87);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(278, 22);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(278, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(24, 177);
            this.lbDni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(43, 16);
            this.lbDni.TabIndex = 3;
            this.lbDni.Text = "DNI *";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(24, 134);
            this.lbDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(83, 16);
            this.lbDireccion.TabIndex = 2;
            this.lbDireccion.Text = "Dirección *";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(24, 90);
            this.lbApellidos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(83, 16);
            this.lbApellidos.TabIndex = 1;
            this.lbApellidos.Text = "Apellidos *";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(24, 45);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(72, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre *";
            // 
            // datosVuelo
            // 
            this.datosVuelo.Controls.Add(this.txtVuelta);
            this.datosVuelo.Controls.Add(this.txtIda);
            this.datosVuelo.Controls.Add(this.txtDestino);
            this.datosVuelo.Controls.Add(this.txtOrigen);
            this.datosVuelo.Controls.Add(this.lbVuelta);
            this.datosVuelo.Controls.Add(this.lbIda);
            this.datosVuelo.Controls.Add(this.lbDestino);
            this.datosVuelo.Controls.Add(this.lbOrigen);
            this.datosVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosVuelo.Location = new System.Drawing.Point(538, 83);
            this.datosVuelo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.datosVuelo.Name = "datosVuelo";
            this.datosVuelo.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.datosVuelo.Size = new System.Drawing.Size(441, 243);
            this.datosVuelo.TabIndex = 1;
            this.datosVuelo.TabStop = false;
            this.datosVuelo.Text = "DATOS DEL VUELO";
            // 
            // txtVuelta
            // 
            this.txtVuelta.Enabled = false;
            this.txtVuelta.Location = new System.Drawing.Point(120, 173);
            this.txtVuelta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtVuelta.Name = "txtVuelta";
            this.txtVuelta.ReadOnly = true;
            this.txtVuelta.Size = new System.Drawing.Size(282, 22);
            this.txtVuelta.TabIndex = 11;
            // 
            // txtIda
            // 
            this.txtIda.Enabled = false;
            this.txtIda.Location = new System.Drawing.Point(120, 130);
            this.txtIda.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtIda.Name = "txtIda";
            this.txtIda.ReadOnly = true;
            this.txtIda.Size = new System.Drawing.Size(282, 22);
            this.txtIda.TabIndex = 10;
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(120, 87);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(282, 22);
            this.txtDestino.TabIndex = 9;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Enabled = false;
            this.txtOrigen.Location = new System.Drawing.Point(120, 43);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(282, 22);
            this.txtOrigen.TabIndex = 8;
            // 
            // lbVuelta
            // 
            this.lbVuelta.AutoSize = true;
            this.lbVuelta.Location = new System.Drawing.Point(23, 177);
            this.lbVuelta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbVuelta.Name = "lbVuelta";
            this.lbVuelta.Size = new System.Drawing.Size(96, 16);
            this.lbVuelta.TabIndex = 3;
            this.lbVuelta.Text = "Fecha vuelta";
            // 
            // lbIda
            // 
            this.lbIda.AutoSize = true;
            this.lbIda.Location = new System.Drawing.Point(23, 134);
            this.lbIda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIda.Name = "lbIda";
            this.lbIda.Size = new System.Drawing.Size(76, 16);
            this.lbIda.TabIndex = 2;
            this.lbIda.Text = "Fecha ida";
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(23, 90);
            this.lbDestino.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(60, 16);
            this.lbDestino.TabIndex = 1;
            this.lbDestino.Text = "Destino";
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Location = new System.Drawing.Point(23, 46);
            this.lbOrigen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(53, 16);
            this.lbOrigen.TabIndex = 0;
            this.lbOrigen.Text = "Origen";
            // 
            // btComprar
            // 
            this.btComprar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btComprar.Location = new System.Drawing.Point(322, 375);
            this.btComprar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(385, 51);
            this.btComprar.TabIndex = 7;
            this.btComprar.Text = "COMPRAR BILLETE";
            this.btComprar.UseVisualStyleBackColor = false;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAviso.Location = new System.Drawing.Point(64, 347);
            this.lbAviso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(46, 16);
            this.lbAviso.TabIndex = 8;
            this.lbAviso.Text = "Aviso";
            this.lbAviso.Visible = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Location = new System.Drawing.Point(64, 37);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(106, 16);
            this.lbTitulo.TabIndex = 23;
            this.lbTitulo.Text = "vuelosAC.com";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 54);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Comprar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 460);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.datosVuelo);
            this.Controls.Add(this.datosPersonales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Comprar2";
            this.Text = "Datos Pasajero";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Comprar2_Click);
            this.datosPersonales.ResumeLayout(false);
            this.datosPersonales.PerformLayout();
            this.datosVuelo.ResumeLayout(false);
            this.datosVuelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox datosPersonales;
        private System.Windows.Forms.GroupBox datosVuelo;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.Label lbIda;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtVuelta;
        private System.Windows.Forms.TextBox txtIda;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lbVuelta;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}