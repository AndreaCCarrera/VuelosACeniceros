namespace VuelosACeniceros.Administrador
{
    partial class MenuAdmin
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
            this.btAeropuertos = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.btVerBilletes = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupFichero = new System.Windows.Forms.GroupBox();
            this.txtFichero = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupFichero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAeropuertos
            // 
            this.btAeropuertos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btAeropuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAeropuertos.Location = new System.Drawing.Point(51, 37);
            this.btAeropuertos.Name = "btAeropuertos";
            this.btAeropuertos.Size = new System.Drawing.Size(231, 37);
            this.btAeropuertos.TabIndex = 0;
            this.btAeropuertos.Text = "CREAR AEROPUERTOS";
            this.btAeropuertos.UseVisualStyleBackColor = false;
            this.btAeropuertos.Click += new System.EventHandler(this.btAeropuertos_Click);
            // 
            // btClientes
            // 
            this.btClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientes.Location = new System.Drawing.Point(51, 94);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(231, 37);
            this.btClientes.TabIndex = 1;
            this.btClientes.Text = "AÑADIR/ ELIMINAR CLIENTES";
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btVerBilletes
            // 
            this.btVerBilletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerBilletes.Location = new System.Drawing.Point(51, 151);
            this.btVerBilletes.Name = "btVerBilletes";
            this.btVerBilletes.Size = new System.Drawing.Size(231, 36);
            this.btVerBilletes.TabIndex = 2;
            this.btVerBilletes.Text = "VER BILLETES";
            this.btVerBilletes.UseVisualStyleBackColor = true;
            this.btVerBilletes.Click += new System.EventHandler(this.btVerBilletes_Click);
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(51, 208);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(231, 35);
            this.btModificar.TabIndex = 3;
            this.btModificar.Text = "MODIFICAR BILLETES";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(53, 432);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(231, 52);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // groupFichero
            // 
            this.groupFichero.Controls.Add(this.txtFichero);
            this.groupFichero.Controls.Add(this.btGuardar);
            this.groupFichero.Controls.Add(this.btCargar);
            this.groupFichero.Location = new System.Drawing.Point(44, 278);
            this.groupFichero.Name = "groupFichero";
            this.groupFichero.Size = new System.Drawing.Size(247, 118);
            this.groupFichero.TabIndex = 5;
            this.groupFichero.TabStop = false;
            // 
            // txtFichero
            // 
            this.txtFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFichero.Location = new System.Drawing.Point(15, 81);
            this.txtFichero.Name = "txtFichero";
            this.txtFichero.Size = new System.Drawing.Size(213, 22);
            this.txtFichero.TabIndex = 8;
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(153, 19);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 44);
            this.btGuardar.TabIndex = 7;
            this.btGuardar.Text = "Guardar Fichero";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCargar
            // 
            this.btCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargar.Location = new System.Drawing.Point(15, 19);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 44);
            this.btCargar.TabIndex = 6;
            this.btCargar.Text = "Cargar Fichero";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "Archivos txt|*.txt|Archivos doc|*.doc";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Archivos txt|*.txt|Archivos doc|*.doc";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 508);
            this.Controls.Add(this.groupFichero);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btVerBilletes);
            this.Controls.Add(this.btClientes);
            this.Controls.Add(this.btAeropuertos);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.groupFichero.ResumeLayout(false);
            this.groupFichero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAeropuertos;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btVerBilletes;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox groupFichero;
        private System.Windows.Forms.TextBox txtFichero;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}