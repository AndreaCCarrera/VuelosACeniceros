using Model;
using System;
using System.Windows.Forms;

namespace VuelosACeniceros.Cliente
{
    public partial class Historico : Form
    {
        private BindingSource bindingSource = new BindingSource();


        public Historico()
        {
            InitializeComponent();
        }

        // Se cargan los vuelos de la persona y se muestran en un DataGridView
        private void Historico_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = typeof(Vuelo);
            dataVuelos.AutoGenerateColumns = true;
            dataVuelos.DataSource = bindingSource;
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            dataVuelos.DataSource = null;
            dataVuelos.DataSource = Entrada.billetes.Buscar_Vuelos(Entrada.persona.Dni);
            foreach (DataGridViewColumn columna in dataVuelos.Columns)
            {
                if (columna.Visible)
                {
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
            }
            dataVuelos.Columns[dataVuelos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataVuelos.CurrentCell = null;

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
