namespace VuelosACeniceros.Administrador
{
    partial class VerBillete
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartBilletes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartBilletes)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBilletes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBilletes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBilletes.Legends.Add(legend1);
            this.chartBilletes.Location = new System.Drawing.Point(46, 31);
            this.chartBilletes.Name = "chartBilletes";
            this.chartBilletes.Size = new System.Drawing.Size(504, 274);
            this.chartBilletes.TabIndex = 0;
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(510, 328);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 32);
            this.btVolver.TabIndex = 44;
            this.btVolver.Text = "VOLVER";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // VerBillete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 381);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.chartBilletes);
            this.Name = "VerBillete";
            this.Text = "Billetes por cliente";
            this.Load += new System.EventHandler(this.VerBillete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBilletes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBilletes;
        private System.Windows.Forms.Button btVolver;
    }
}