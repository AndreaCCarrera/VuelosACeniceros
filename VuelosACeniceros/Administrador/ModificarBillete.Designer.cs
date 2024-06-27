namespace VuelosACeniceros.Administrador
{
    partial class ModificarBillete
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
            this.lbId = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.dateIda = new System.Windows.Forms.DateTimePicker();
            this.dateVuelta = new System.Windows.Forms.DateTimePicker();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.checkIV = new System.Windows.Forms.CheckBox();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbIda = new System.Windows.Forms.Label();
            this.lbVuelta = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbAvisos = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.groupFichero = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(41, 42);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(86, 16);
            this.lbId.TabIndex = 22;
            this.lbId.Text = "ID BILLETE";
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(374, 28);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(148, 44);
            this.btModificar.TabIndex = 21;
            this.btModificar.Text = "MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // numId
            // 
            this.numId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numId.Location = new System.Drawing.Point(133, 42);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 22);
            this.numId.TabIndex = 23;
            this.numId.ValueChanged += new System.EventHandler(this.numId_ValueChanged);
            // 
            // dateIda
            // 
            this.dateIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIda.Location = new System.Drawing.Point(53, 220);
            this.dateIda.MinDate = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);
            this.dateIda.Name = "dateIda";
            this.dateIda.Size = new System.Drawing.Size(200, 22);
            this.dateIda.TabIndex = 24;
            this.dateIda.ValueChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // dateVuelta
            // 
            this.dateVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVuelta.Location = new System.Drawing.Point(322, 220);
            this.dateVuelta.MinDate = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);
            this.dateVuelta.Name = "dateVuelta";
            this.dateVuelta.Size = new System.Drawing.Size(200, 22);
            this.dateVuelta.TabIndex = 25;
            this.dateVuelta.ValueChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(53, 155);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(200, 24);
            this.cmbOrigen.TabIndex = 26;
            this.cmbOrigen.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(322, 155);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(200, 24);
            this.cmbDestino.TabIndex = 27;
            this.cmbDestino.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(100, 333);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.TextChanged += new System.EventHandler(this.NewTextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(334, 333);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(188, 22);
            this.txtApellidos.TabIndex = 30;
            this.txtApellidos.TextChanged += new System.EventHandler(this.NewTextChanged);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(100, 379);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(149, 22);
            this.txtDni.TabIndex = 31;
            this.txtDni.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(334, 379);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(188, 22);
            this.txtDireccion.TabIndex = 32;
            this.txtDireccion.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigen.Location = new System.Drawing.Point(50, 137);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(59, 16);
            this.lbOrigen.TabIndex = 33;
            this.lbOrigen.Text = "ORIGEN";
            // 
            // checkIV
            // 
            this.checkIV.AutoSize = true;
            this.checkIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIV.Location = new System.Drawing.Point(51, 93);
            this.checkIV.Name = "checkIV";
            this.checkIV.Size = new System.Drawing.Size(111, 20);
            this.checkIV.TabIndex = 34;
            this.checkIV.Text = "IDA / VUELTA";
            this.checkIV.UseVisualStyleBackColor = true;
            this.checkIV.CheckedChanged += new System.EventHandler(this.checkIV_CheckedChanged);
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestino.Location = new System.Drawing.Point(319, 138);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(67, 16);
            this.lbDestino.TabIndex = 35;
            this.lbDestino.Text = "DESTINO";
            // 
            // lbIda
            // 
            this.lbIda.AutoSize = true;
            this.lbIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIda.Location = new System.Drawing.Point(50, 202);
            this.lbIda.Name = "lbIda";
            this.lbIda.Size = new System.Drawing.Size(77, 16);
            this.lbIda.TabIndex = 36;
            this.lbIda.Text = "FECHA IDA";
            // 
            // lbVuelta
            // 
            this.lbVuelta.AutoSize = true;
            this.lbVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVuelta.Location = new System.Drawing.Point(319, 203);
            this.lbVuelta.Name = "lbVuelta";
            this.lbVuelta.Size = new System.Drawing.Size(108, 16);
            this.lbVuelta.TabIndex = 37;
            this.lbVuelta.Text = "FECHA VUELTA";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(38, 336);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 38;
            this.lbNombre.Text = "Nombre";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(48, 382);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(30, 16);
            this.lbDni.TabIndex = 39;
            this.lbDni.Text = "DNI";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(264, 336);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(64, 16);
            this.lbApellidos.TabIndex = 40;
            this.lbApellidos.Text = "Apellidos";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(264, 382);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(64, 16);
            this.lbDireccion.TabIndex = 41;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbAvisos
            // 
            this.lbAvisos.AutoSize = true;
            this.lbAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisos.Location = new System.Drawing.Point(319, 93);
            this.lbAvisos.Name = "lbAvisos";
            this.lbAvisos.Size = new System.Drawing.Size(54, 16);
            this.lbAvisos.TabIndex = 42;
            this.lbAvisos.Text = "Avisos";
            this.lbAvisos.Visible = false;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(484, 435);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 32);
            this.btVolver.TabIndex = 43;
            this.btVolver.Text = "VOLVER";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // groupFichero
            // 
            this.groupFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFichero.Location = new System.Drawing.Point(32, 281);
            this.groupFichero.Name = "groupFichero";
            this.groupFichero.Size = new System.Drawing.Size(513, 137);
            this.groupFichero.TabIndex = 44;
            this.groupFichero.TabStop = false;
            this.groupFichero.Text = "DATOS CLIENTE";
            // 
            // ModificarBillete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 489);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lbAvisos);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbVuelta);
            this.Controls.Add(this.lbIda);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.checkIV);
            this.Controls.Add(this.lbOrigen);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.dateVuelta);
            this.Controls.Add(this.dateIda);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.groupFichero);
            this.Name = "ModificarBillete";
            this.Text = "Modificar Billete";
            this.Load += new System.EventHandler(this.ModificarBillete_Load);
            this.Click += new System.EventHandler(this.ModificarBillete_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.DateTimePicker dateIda;
        private System.Windows.Forms.DateTimePicker dateVuelta;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.CheckBox checkIV;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbIda;
        private System.Windows.Forms.Label lbVuelta;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbAvisos;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.GroupBox groupFichero;
    }
}