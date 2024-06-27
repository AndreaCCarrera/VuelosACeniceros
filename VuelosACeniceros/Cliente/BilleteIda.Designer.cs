namespace VuelosACeniceros.Cliente
{
    partial class BilleteIda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilleteIda));
            this.picIda = new System.Windows.Forms.PictureBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.lbBillete = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIda)).BeginInit();
            this.SuspendLayout();
            // 
            // picIda
            // 
            this.picIda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIda.BackgroundImage")));
            this.picIda.Location = new System.Drawing.Point(0, 0);
            this.picIda.Name = "picIda";
            this.picIda.Size = new System.Drawing.Size(676, 257);
            this.picIda.TabIndex = 21;
            this.picIda.TabStop = false;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(50, 72);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(54, 20);
            this.lbFecha.TabIndex = 22;
            this.lbFecha.Text = "Fecha";
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigen.Location = new System.Drawing.Point(47, 121);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(56, 20);
            this.lbOrigen.TabIndex = 23;
            this.lbOrigen.Text = "Origen";
            // 
            // lbBillete
            // 
            this.lbBillete.AutoSize = true;
            this.lbBillete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillete.Location = new System.Drawing.Point(208, 72);
            this.lbBillete.Name = "lbBillete";
            this.lbBillete.Size = new System.Drawing.Size(64, 20);
            this.lbBillete.TabIndex = 24;
            this.lbBillete.Text = "IdVuelo";
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestino.Location = new System.Drawing.Point(208, 121);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(64, 20);
            this.lbDestino.TabIndex = 25;
            this.lbDestino.Text = "Destino";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(208, 168);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(33, 20);
            this.lbDni.TabIndex = 26;
            this.lbDni.Text = "Dni";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(47, 193);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(144, 20);
            this.lbNombre.TabIndex = 27;
            this.lbNombre.Text = "Nombre y Apellidos";
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(589, 274);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 32);
            this.btVolver.TabIndex = 28;
            this.btVolver.Text = "VOLVER";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // BilleteIda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(688, 318);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.lbBillete);
            this.Controls.Add(this.lbOrigen);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.picIda);
            this.Name = "BilleteIda";
            this.Text = "BilleteIda";
            ((System.ComponentModel.ISupportInitialize)(this.picIda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picIda;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.Label lbBillete;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btVolver;
    }
}