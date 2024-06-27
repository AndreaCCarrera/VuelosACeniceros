namespace VuelosACeniceros.Administrador
{
    partial class VistaAeropuertos
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
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAnadir = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.dataAeropuertos = new System.Windows.Forms.DataGridView();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAeropuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(320, 94);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(148, 43);
            this.btEliminar.TabIndex = 25;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAnadir
            // 
            this.btAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnadir.Location = new System.Drawing.Point(320, 34);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(148, 44);
            this.btAnadir.TabIndex = 24;
            this.btAnadir.Text = "AÑADIR";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(107, 35);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(167, 22);
            this.txtCiudad.TabIndex = 20;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiudad.Location = new System.Drawing.Point(28, 31);
            this.lbCiudad.Margin = new System.Windows.Forms.Padding(0);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Padding = new System.Windows.Forms.Padding(6);
            this.lbCiudad.Size = new System.Drawing.Size(76, 28);
            this.lbCiudad.TabIndex = 16;
            this.lbCiudad.Text = "CIUDAD";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(319, 171);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(66, 16);
            this.lbMensaje.TabIndex = 30;
            this.lbMensaje.Text = "Mensaje";
            // 
            // dataAeropuertos
            // 
            this.dataAeropuertos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataAeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAeropuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciudad});
            this.dataAeropuertos.Location = new System.Drawing.Point(37, 94);
            this.dataAeropuertos.Name = "dataAeropuertos";
            this.dataAeropuertos.ReadOnly = true;
            this.dataAeropuertos.Size = new System.Drawing.Size(237, 189);
            this.dataAeropuertos.TabIndex = 31;
            this.dataAeropuertos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataAeropuertos_RowHeaderMouseClick);
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(404, 263);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 32);
            this.btVolver.TabIndex = 32;
            this.btVolver.Text = "VOLVER";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // VistaAeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 307);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dataAeropuertos);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lbCiudad);
            this.Name = "VistaAeropuertos";
            this.Text = "Aeropuertos";
            this.Load += new System.EventHandler(this.Aeropuertos_Load);
            this.Click += new System.EventHandler(this.VistaAeropuertos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataAeropuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.DataGridView dataAeropuertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.Button btVolver;
    }
}