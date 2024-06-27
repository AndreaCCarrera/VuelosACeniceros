namespace VuelosACeniceros
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFondo.BackgroundImage")));
            this.picFondo.Location = new System.Drawing.Point(0, -1);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(610, 468);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(47, 47);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            this.cmbOrigen.Leave += new System.EventHandler(this.cmbOrigen_Leave);
            // 
            // cmbDestino
            // 
            this.cmbDestino.Enabled = false;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(208, 47);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            this.cmbDestino.Leave += new System.EventHandler(this.cmbDestino_Leave);
            // 
            // btVuelta
            // 
            this.btVuelta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVuelta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVuelta.Location = new System.Drawing.Point(368, 33);
            this.btVuelta.Name = "btVuelta";
            this.btVuelta.Size = new System.Drawing.Size(189, 46);
            this.btVuelta.TabIndex = 3;
            this.btVuelta.Text = "SELECCIONAR VUELTA";
            this.btVuelta.UseVisualStyleBackColor = false;
            this.btVuelta.Click += new System.EventHandler(this.btVuelta_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(79, 121);
            this.monthCalendar1.MinDate = new System.DateTime(2023, 11, 8, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(330, 121);
            this.monthCalendar2.MinDate = new System.DateTime(2023, 11, 8, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // btComprar
            // 
            this.btComprar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btComprar.Location = new System.Drawing.Point(144, 386);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(289, 57);
            this.btComprar.TabIndex = 6;
            this.btComprar.Text = "COMPRAR BILLETE";
            this.btComprar.UseVisualStyleBackColor = false;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // lbTitulo1
            // 
            this.lbTitulo1.AutoSize = true;
            this.lbTitulo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo1.Location = new System.Drawing.Point(80, 28);
            this.lbTitulo1.Name = "lbTitulo1";
            this.lbTitulo1.Size = new System.Drawing.Size(55, 13);
            this.lbTitulo1.TabIndex = 7;
            this.lbTitulo1.Text = "ORIGEN";
            // 
            // lbTitulo2
            // 
            this.lbTitulo2.AutoSize = true;
            this.lbTitulo2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo2.Location = new System.Drawing.Point(240, 28);
            this.lbTitulo2.Name = "lbTitulo2";
            this.lbTitulo2.Size = new System.Drawing.Size(62, 13);
            this.lbTitulo2.TabIndex = 8;
            this.lbTitulo2.Text = "DESTINO";
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.BackColor = System.Drawing.SystemColors.Menu;
            this.lbOrigen.Location = new System.Drawing.Point(76, 328);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(150, 13);
            this.lbOrigen.TabIndex = 9;
            this.lbOrigen.Text = "Vuelo de origen seleccionado:";
            this.lbOrigen.Visible = false;
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbDestino.Location = new System.Drawing.Point(76, 355);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(155, 13);
            this.lbDestino.TabIndex = 10;
            this.lbDestino.Text = "Vuelo de destino seleccionado:";
            this.lbDestino.Visible = false;
            // 
            // lbIda
            // 
            this.lbIda.AutoSize = true;
            this.lbIda.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbIda.Location = new System.Drawing.Point(327, 328);
            this.lbIda.Name = "lbIda";
            this.lbIda.Size = new System.Drawing.Size(91, 13);
            this.lbIda.TabIndex = 11;
            this.lbIda.Text = "Con fecha de ida:";
            this.lbIda.Visible = false;
            // 
            // lbVuelta
            // 
            this.lbVuelta.AutoSize = true;
            this.lbVuelta.Location = new System.Drawing.Point(327, 355);
            this.lbVuelta.Name = "lbVuelta";
            this.lbVuelta.Size = new System.Drawing.Size(106, 13);
            this.lbVuelta.TabIndex = 12;
            this.lbVuelta.Text = "Con fecha de vuelta:";
            this.lbVuelta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 158);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitulo3
            // 
            this.lbTitulo3.AutoSize = true;
            this.lbTitulo3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbTitulo3.Location = new System.Drawing.Point(83, 96);
            this.lbTitulo3.Name = "lbTitulo3";
            this.lbTitulo3.Size = new System.Drawing.Size(70, 13);
            this.lbTitulo3.TabIndex = 14;
            this.lbTitulo3.Text = "Fecha de Ida";
            // 
            // lbTitulo4
            // 
            this.lbTitulo4.AutoSize = true;
            this.lbTitulo4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbTitulo4.Location = new System.Drawing.Point(330, 95);
            this.lbTitulo4.Name = "lbTitulo4";
            this.lbTitulo4.Size = new System.Drawing.Size(85, 13);
            this.lbTitulo4.TabIndex = 15;
            this.lbTitulo4.Text = "Fecha de Vuelta";
            this.lbTitulo4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 454);
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
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picFondo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

