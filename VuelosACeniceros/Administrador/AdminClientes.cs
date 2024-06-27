using System;
using Model;
using System.Drawing;
using System.Windows.Forms;

namespace VuelosACeniceros
{

    public partial class AdminClientes : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public AdminClientes()
        {
            InitializeComponent();
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = typeof(Persona);
            dataClientes.AutoGenerateColumns = true;
            dataClientes.DataSource = bindingSource;
            ActualizarDataGridView();
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtDni.Text = string.Empty;
        }

        private void ActualizarDataGridView()
        {
          dataClientes.DataSource = null;
          dataClientes.DataSource = Entrada.personas.Lista_personas;
            foreach (DataGridViewColumn columna in dataClientes.Columns)
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
            dataClientes.Columns[dataClientes.Columns.Count - 2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataClientes.CurrentCell = null;
            dataClientes.Columns[4].Visible = false;
        }

        //Cambia el color del botón añadir si todos los campos necesarios están completados
        private void NewTextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellidos.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtDni.Text))
            {
                btAnadir.BackColor = Color.Blue;
                btAnadir.ForeColor = Color.White;
                lbSeleccionado.Visible = false;
                lbSeleccionado.ForeColor = Color.Black;
            }
            
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            if (btAnadir.BackColor == Color.Blue)
            {
                string dni = txtDni.Text;

                if (dni.Equals(Entrada.personas.Obtener_persona(dni).Dni))
                {
                    MessageBox.Show("Ya existe una persona con este DNI en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Persona nuevaPersona = new Persona
                    {
                        Nombre = txtNombre.Text,
                        Apellidos = txtApellidos.Text,
                        Direccion = txtDireccion.Text,
                        Dni = txtDni.Text,
                        Password = txtDni.Text
                    };

                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                       nuevaPersona.Password = txtPassword.Text;
                       lbSeleccionado.Text = "Persona añadida correctamente";
                       lbSeleccionado.Visible = true;
                    }
                    else
                    {
                       string contrasena = nuevaPersona.Generador_pass(8);
                       nuevaPersona.Password = contrasena;
                       lbSeleccionado.Text = "Persona añadida con la contraseña: "+ contrasena;
                       lbSeleccionado.Visible = true;

                    }

                    Entrada.personas.Anadir_persona(nuevaPersona);

                    //bindingSource.ResetBindings(false);
                    ActualizarDataGridView();

                    txtPassword.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtDireccion.Text = "";
                    txtDni.Text = "";

                    btAnadir.BackColor = SystemColors.Control;
                    btAnadir.ForeColor = SystemColors.ControlText;

                }
            }
            else
            {
                lbSeleccionado.ForeColor = Color.Red;
                lbSeleccionado.Text = "Faltan campos por rellenar.";
                lbSeleccionado.Visible = true;
            }
        }

        //Cambia el color para activar el botón Eliminar
        private void dataClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dataClientes.SelectedRows.Count > 0)
            {
                btEliminar.BackColor = Color.Blue;
                btEliminar.ForeColor = Color.White;
                lbSeleccionado.ForeColor = Color.Black;
                lbSeleccionado.Text = "Nombre del cliente seleccionado: " + dataClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                lbSeleccionado.Visible = true;
            }
            else
            {
                btEliminar.BackColor = SystemColors.Control;
                btEliminar.ForeColor = SystemColors.ControlText;
            }

        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;

            if (btEliminar.BackColor == Color.Blue && dataClientes.SelectedRows.Count > 0)
            {
                Persona personaSeleccionada = dataClientes.SelectedRows[0].DataBoundItem as Persona;


                if (Entrada.billetes.Buscar_dni(personaSeleccionada.Dni) != null)
                {
                    cuerpo = "Esta persona tiene billetes. \r\n ¿Está seguro de que desea borrar?";
                    cabecera = "Billetes asociados";
                    icono = MessageBoxIcon.Exclamation;
                    MessageBoxButtons botones = MessageBoxButtons.OKCancel;
                    result = MessageBox.Show(cuerpo, cabecera, botones, icono);

                    if (result == DialogResult.OK)
                    {
                        Entrada.billetes.Eliminar_billete_dni(personaSeleccionada.Dni);
                        Entrada.personas.Lista_personas.Remove(personaSeleccionada);
                        ActualizarDataGridView();

                        btEliminar.BackColor = SystemColors.Control;
                        btEliminar.ForeColor = SystemColors.ControlText;
                        lbSeleccionado.ForeColor = Color.Black;
                        lbSeleccionado.Text = "Persona eliminada";
                        lbSeleccionado.Visible = true;

                    }
                }
                else
                {
                    Entrada.personas.Lista_personas.Remove(personaSeleccionada);
                    ActualizarDataGridView();

                    btEliminar.BackColor = SystemColors.Control;
                    btEliminar.ForeColor = SystemColors.ControlText;
                    lbSeleccionado.ForeColor = Color.Black;
                    lbSeleccionado.Text = "Persona eliminada";
                    lbSeleccionado.Visible = true;
                }
            }
            else
            {
                lbSeleccionado.ForeColor = Color.Red;
                lbSeleccionado.Text = "Ningún cliente seleccionado.";
                lbSeleccionado.Visible = true;
                btEliminar.BackColor = SystemColors.Control;
                btEliminar.ForeColor = SystemColors.ControlText;
            }
        }

        // Verificar si el carácter introducido no es un dígito
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        // Limpiar las label del formulario
        private void AdminClientes_Click(object sender, EventArgs e)
        {
            lbSeleccionado.Visible = false;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
