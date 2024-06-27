using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VuelosACeniceros.Administrador
{
    public partial class VistaAeropuertos : Form
    {
        public VistaAeropuertos()
        {
            InitializeComponent();
   
        }

        private void Aeropuertos_Load(object sender, System.EventArgs e)
        {
            
            ActualizarDataGridView();
            txtCiudad.Text = string.Empty;
            lbMensaje.ForeColor = Color.Black;
            lbMensaje.Visible = false;
        }

        private void ActualizarDataGridView()
        {
            dataAeropuertos.Columns.Clear();
            DataGridViewTextBoxColumn columnaCiudad = new DataGridViewTextBoxColumn
            {
                HeaderText = "Ciudad",
                DataPropertyName = "Ciudad"
            };
 
            dataAeropuertos.Columns.Add(columnaCiudad);

            dataAeropuertos.DataSource = Entrada.aeropuertos.Lista_aeropuertos
                .Select(ciudad => new { Ciudad = ciudad })
                .ToList();

            foreach (DataGridViewColumn columna in dataAeropuertos.Columns)
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
            dataAeropuertos.Columns[dataAeropuertos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataAeropuertos.CurrentCell = null;
        }

        // Cambia el color para activar el botón añadir
        private void txtNombre_TextChanged(object sender, System.EventArgs e)
        {
            if(txtCiudad.Text != string.Empty)
            {
                btAnadir.BackColor = Color.Blue;
                btAnadir.ForeColor = Color.White;

            }
        }

        private void btAnadir_Click(object sender, System.EventArgs e)
        {
            if(btAnadir.BackColor == Color.Blue) { 

               if(Entrada.aeropuertos.AnadirAeropuerto(txtCiudad.Text))
                {
                    lbMensaje.Text = "Ciudad añadida";
                    lbMensaje.Visible = true;
                    txtCiudad.Text = string.Empty;
                    ActualizarDataGridView();
                    btAnadir.BackColor = SystemColors.Control;
                    btAnadir.ForeColor = SystemColors.ControlText;

                }
                else
                {
                    lbMensaje.Text = "Ya existe la ciudad";
                    lbMensaje.ForeColor = Color.Red;
                    lbMensaje.Visible = true;
                    txtCiudad.Text = string.Empty;
                    btAnadir.BackColor = SystemColors.Control;
                    btAnadir.ForeColor = SystemColors.ControlText;
                }
                    
            }
        }

        //Cambia el color para activar el botón Eliminar
        private void dataAeropuertos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataAeropuertos.SelectedRows.Count > 0)
            {
                btEliminar.BackColor = Color.Blue;
                btEliminar.ForeColor = Color.White;
                lbMensaje.ForeColor = Color.Black;
                lbMensaje.Text = "Ciudad seleccionada: \r\n" + dataAeropuertos.SelectedRows[0].Cells[0].Value.ToString();
                lbMensaje.Visible = true;
            }

        }

        private void btEliminar_Click(object sender, System.EventArgs e)
        {

            if (btEliminar.BackColor == Color.Blue && dataAeropuertos.SelectedRows.Count > 0)
            {
                string ciudad = dataAeropuertos.SelectedRows[0].Cells[0].Value.ToString();
                if (Entrada.aeropuertos.EliminarAeropuerto(ciudad))
                {
                    lbMensaje.ForeColor = Color.Black;
                    lbMensaje.Text = "Ciudad eliminada";
                    lbMensaje.Visible = true;
                    ActualizarDataGridView();
                    btEliminar.BackColor = SystemColors.Control;
                    btEliminar.ForeColor = SystemColors.ControlText;
                }
                else
                {
                    lbMensaje.ForeColor = Color.Red;
                    lbMensaje.Text = "No se ha podido \r\n eliminar la ciudad";
                    lbMensaje.Visible = true;
                    btEliminar.BackColor = SystemColors.Control;
                    btEliminar.ForeColor = SystemColors.ControlText;
                }


            }
            else
            {
                lbMensaje.ForeColor = Color.Red;
                lbMensaje.Text = "Ninguna ciudad \r\n seleccionada.";
                lbMensaje.Visible = true;
                btEliminar.BackColor = SystemColors.Control;
                btEliminar.ForeColor = SystemColors.ControlText;
            }
        }

        // Verificar si el carácter introducido no es un dígito
        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //Ocultar label que se haya quedado fijado
        private void VistaAeropuertos_Click(object sender, System.EventArgs e)
        {
            lbMensaje.Visible= false;
        }

        private void btVolver_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

      
    }
}
