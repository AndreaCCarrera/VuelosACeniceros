namespace VuelosACeniceros
{
    partial class Comprar1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar1));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btVuelta = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.btComprar = new System.Windows.Forms.Button();
            this.lbTitulo1 = new System.Windows.Forms.Label();
            this.lbTitulo2 = new System.Windows.Forms.Label();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbIda = new System.Windows.Forms.Label();
            this.lbVuelta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitulo3 = new System.Windows.Forms.Label();
            this.lbTitulo4 = new System.Windows.Forms.Label();
            this.lbCompra = new System.Windows.Forms.Label();
            this.btInfo = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbComprador = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFondo.BackgroundImage")));
            this.picFondo.Location = new System.Drawing.Point(0, -15);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(610, 462);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(40, 83);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(130, 24);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedItemChanged);
            this.cmbOrigen.Leave += new System.EventHandler(this.cmbOrigen_Leave);
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Enabled = false;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(211, 83);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(129, 24);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedItemChanged);
            this.cmbDestino.Leave += new System.EventHandler(this.cmbDestino_Leave);
            // 
            // btVuelta
            // 
            this.btVuelta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVuelta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVuelta.Location = new System.Drawing.Point(373, 74);
            this.btVuelta.Name = "btVuelta";
            this.btVuelta.Size = new System.Drawing.Size(189, 40);
            this.btVuelta.TabIndex = 3;
            this.btVuelta.Text = "SELECCIONAR VUELTA";
            this.btVuelta.UseVisualStyleBackColor = false;
            this.btVuelta.Click += new System.EventHandler(this.btVuelta_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(79, 157);
            this.monthCalendar1.MinDate = new System.DateTime(2023, 11, 8, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(330, 157);
            this.monthCalendar2.MinDate = new System.DateTime(2023, 11, 8, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // btComprar
            // 
            this.btComprar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btComprar.Location = new System.Drawing.Point(162, 453);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(289, 46);
            this.btComprar.TabIndex = 6;
            this.btComprar.Text = "COMPRAR BILLETE";
            this.btComprar.UseVisualStyleBackColor = false;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // lbTitulo1
            // 
            this.lbTitulo1.AutoSize = true;
            this.lbTitulo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo1.Location = new System.Drawing.Point(76, 64);
            this.lbTitulo1.Name = "lbTitulo1";
            this.lbTitulo1.Size = new System.Drawing.Size(65, 16);
            this.lbTitulo1.TabIndex = 7;
            this.lbTitulo1.Text = "ORIGEN";
            // 
            // lbTitulo2
            // 
            this.lbTitulo2.AutoSize = true;
            this.lbTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo2.Location = new System.Drawing.Point(240, 64);
            this.lbTitulo2.Name = "lbTitulo2";
            this.lbTitulo2.Size = new System.Drawing.Size(74, 16);
            this.lbTitulo2.TabIndex = 8;
            this.lbTitulo2.Text = "DESTINO";
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.BackColor = System.Drawing.SystemColors.Menu;
            this.lbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigen.Location = new System.Drawing.Point(46, 389);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(135, 16);
            this.lbOrigen.TabIndex = 9;
            this.lbOrigen.Text = "Origen seleccionado:";
            this.lbOrigen.Visible = false;
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestino.Location = new System.Drawing.Point(46, 416);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(141, 16);
            this.lbDestino.TabIndex = 10;
            this.lbDestino.Text = "Destino seleccionado:";
            this.lbDestino.Visible = false;
            // 
            // lbIda
            // 
            this.lbIda.AutoSize = true;
            this.lbIda.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIda.Location = new System.Drawing.Point(300, 389);
            this.lbIda.Name = "lbIda";
            this.lbIda.Size = new System.Drawing.Size(89, 16);
            this.lbIda.TabIndex = 11;
            this.lbIda.Text = "Fecha de ida:";
            this.lbIda.Visible = false;
            // 
            // lbVuelta
            // 
            this.lbVuelta.AutoSize = true;
            this.lbVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVuelta.Location = new System.Drawing.Point(300, 416);
            this.lbVuelta.Name = "lbVuelta";
            this.lbVuelta.Size = new System.Drawing.Size(106, 16);
            this.lbVuelta.TabIndex = 12;
            this.lbVuelta.Text = "Fecha de vuelta:";
            this.lbVuelta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 221);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitulo3
            // 
            this.lbTitulo3.AutoSize = true;
            this.lbTitulo3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbTitulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo3.Location = new System.Drawing.Point(83, 132);
            this.lbTitulo3.Name = "lbTitulo3";
            this.lbTitulo3.Size = new System.Drawing.Size(86, 16);
            this.lbTitulo3.TabIndex = 14;
            this.lbTitulo3.Text = "Fecha de Ida";
            // 
            // lbTitulo4
            // 
            this.lbTitulo4.AutoSize = true;
            this.lbTitulo4.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo4.Location = new System.Drawing.Point(330, 131);
            this.lbTitulo4.Name = "lbTitulo4";
            this.lbTitulo4.Size = new System.Drawing.Size(105, 16);
            this.lbTitulo4.TabIndex = 15;
            this.lbTitulo4.Text = "Fecha de Vuelta";
            this.lbTitulo4.Visible = false;
            // 
            // lbCompra
            // 
            this.lbCompra.AutoSize = true;
            this.lbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompra.Location = new System.Drawing.Point(46, 522);
            this.lbCompra.Name = "lbCompra";
            this.lbCompra.Size = new System.Drawing.Size(196, 16);
            this.lbCompra.TabIndex = 16;
            this.lbCompra.Text = "Compra realizada con éxito por:";
            this.lbCompra.Visible = false;
            // 
            // btInfo
            // 
            this.btInfo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInfo.Location = new System.Drawing.Point(482, 453);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(62, 46);
            this.btInfo.TabIndex = 18;
            this.btInfo.Text = "INFO";
            this.btInfo.UseVisualStyleBackColor = false;
            this.btInfo.Visible = false;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Location = new System.Drawing.Point(60, 16);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(106, 16);
            this.lbTitulo.TabIndex = 21;
            this.lbTitulo.Text = "vuelosAC.com";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 44);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lbComprador
            // 
            this.lbComprador.AutoSize = true;
            this.lbComprador.Location = new System.Drawing.Point(258, 512);
            this.lbComprador.Name = "lbComprador";
            this.lbComprador.Size = new System.Drawing.Size(39, 13);
            this.lbComprador.TabIndex = 22;
            this.lbComprador.Text = "Cliente";
            this.lbComprador.Visible = false;
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(510, 537);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 32);
            this.btVolver.TabIndex = 33;
            this.btVolver.Text = "VOLVER";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // Comprar1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 590);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lbComprador);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.lbCompra);
            this.Controls.Add(this.lbTitulo4);
            this.Controls.Add(this.lbTitulo3);
            this.Controls.Add(this.lbVuelta);
            this.Controls.Add(this.lbIda);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.lbOrigen);
            this.Controls.Add(this.lbTitulo2);
            this.Controls.Add(this.lbTitulo1);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btVuelta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.picFondo);
            this.Name = "Comprar1";
            this.Text = "Comprar Vuelo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btVuelta;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.Label lbTitulo1;
        private System.Windows.Forms.Label lbTitulo2;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbIda;
        private System.Windows.Forms.Label lbVuelta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitulo3;
        private System.Windows.Forms.Label lbTitulo4;
        private System.Windows.Forms.Label lbCompra;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbComprador;
        private System.Windows.Forms.Button btVolver;
    }
}

