using Model;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VuelosACeniceros.Administrador
{
    public partial class VerBillete : Form
    {
        private Series s; 
        public VerBillete()
        {   
            InitializeComponent();
           
        }

        private void VerBillete_Load(object sender, EventArgs e)
        {
            chartBilletes.Palette = ChartColorPalette.Pastel;
            chartBilletes.Titles.Add("Numero de vuelos");

            // Rellenar el chart con los vuelos por persona
            foreach (Persona persona in Entrada.personas.Lista_personas)
            {
                int numVuelos = Entrada.billetes.Num_vuelos_p(persona.Dni); // Llamada al método que obtiene el num vuelos
                s = chartBilletes.Series.Add(persona.Apellidos);
                s.Points.Add(numVuelos);
                s.Label = numVuelos.ToString();
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

