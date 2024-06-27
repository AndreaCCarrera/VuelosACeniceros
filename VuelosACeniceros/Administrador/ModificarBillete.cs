using Business;
using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VuelosACeniceros.Administrador
{
    public partial class ModificarBillete : Form
    {
        string[] lista = Entrada.aeropuertos.Lista_aeropuertos.ToArray();
        Billetes billetesFecha = new Billetes(); 
        public ModificarBillete()
        {
            InitializeComponent();

        }

        private void ModificarBillete_Load(object sender, EventArgs e)
        {
            Resetear();
            billetesFecha = Entrada.billetes.FiltrarFecha();
            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();
            cmbOrigen.Items.AddRange(lista);
            cmbDestino.Items.AddRange(lista);
            cmbOrigen.SelectedItem = null;
            cmbDestino.SelectedItem = null;
            numId.Value = 0;

        }

        // Deja los elementos en el estado inicial
        private void Resetear()
        { 
     
            dateIda.Value = DateTime.Now;
            dateVuelta.MinDate = DateTime.Now;
            dateVuelta.Value = DateTime.Now;
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            lbAvisos.Visible = false;
            lbAvisos.ForeColor = Color.Black;
            dateVuelta.Visible = false;
            checkIV.Checked = false;
            btModificar.ResetBackColor();
            btModificar.ResetForeColor();

        }

        // Comprueba si el id corresponde a un billete a modificar y carga los datos en los campos en el caso de que sea que sí
        private void numId_ValueChanged(object sender, EventArgs e)
        {   
            int id = (int)numId.Value;
            Billete billModif;
            if (id != 0)
            {
                billModif = billetesFecha.Buscar_id(id);
                if (billModif!= null){

                    
                    cmbOrigen.SelectedItem = billModif.Ida.Origen;
                    cmbDestino.SelectedItem = billModif.Ida.Destino;
                    dateIda.Value = billModif.Ida.Fecha;
                    txtNombre.Text = billModif.Persona.Nombre;
                    txtApellidos.Text = billModif.Persona.Apellidos;
                    txtDni.Text = billModif.Persona.Dni;
                    txtDireccion.Text = billModif.Persona.Direccion;

                    if (billModif.I_v)
                    {
                     checkIV.Checked = true;
                     dateVuelta.Value = billModif.Vuelta.Fecha;
                     dateVuelta.Visible = true;

                    }
                    lbAvisos.Visible = false;
                }
                else
                {   

                    Resetear();
                    numId.Value = id;
                    lbAvisos.ForeColor = Color.Red;
                    lbAvisos.Text = "El id no corresponde con ningún \r\n" +
                                     "billete a modificar";
                    lbAvisos.Visible = true;

                }



            }
            else
            {
                Resetear();
            }
        }

        // Activar el botón de Modificar por color
        private void NewTextChanged(object sender, EventArgs e)
        {    
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellidos.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtDni.Text)&&
                (int)numId.Value!= 0 && cmbDestino.SelectedItem!=null && cmbOrigen.SelectedItem != null && dateIda.Value.Date != DateTime.Now.Date)
            {
                btModificar.BackColor = Color.Blue;
                btModificar.ForeColor = Color.White;
                lbAvisos.Visible = false;
            }
            else
            {
                btModificar.ResetBackColor();
                btModificar.ResetForeColor();
            }
        }

        // Si hay vuelo de vuelta
        private void checkIV_CheckedChanged(object sender, EventArgs e)
        {
            if(checkIV.Checked == true)
            {
                dateVuelta.Visible = true;
                dateVuelta.MinDate = dateIda.Value;
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Boolean i_v = false;
            int id;
            string origen;
            string destino;
            DateTime fechaIda;
            DateTime fechaVuelta;
            string nombre;
            string apellidos;
            string dni;
            string direccion;
            Persona p;
            Vuelo v1;
            Vuelo v2;


            if (btModificar.BackColor == Color.Blue)
            {
              id = (int)numId.Value;
              origen =  cmbOrigen.SelectedItem.ToString();
              destino =  cmbDestino.SelectedItem.ToString();
              fechaIda = dateIda.Value;

              nombre = txtNombre.Text;
              apellidos = txtApellidos.Text;
              dni = txtDni.Text;
              direccion = txtDireccion.Text;
              
              p= new Persona(nombre, apellidos, dni, direccion);
              v1 = new Vuelo(origen, destino, fechaIda);
              

                if (checkIV.Checked)
                {   
                    i_v = true;
                    fechaVuelta = dateVuelta.Value;
                    v2 = new Vuelo(destino, origen, fechaVuelta);

                    Entrada.billetes.ModificarBillete(i_v, id, v1, v2, p);
                    
                }
                else
                {
                    Entrada.billetes.ModificarBillete(i_v, id, v1, v1, p);
                }

                Resetear();
                lbAvisos.ForeColor = Color.Black;
                lbAvisos.Text = "Billete modificado";
                lbAvisos.Visible = true;


            }
            else
            {
                lbAvisos.Text = "Faltan campos por rellenar";
                lbAvisos.ForeColor = Color.Red;
                lbAvisos.Visible = true;
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
        private void ModificarBillete_Click(object sender, EventArgs e)
        {
            lbAvisos.ForeColor = Color.Black;
            lbAvisos.Visible = false;
        }
        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
