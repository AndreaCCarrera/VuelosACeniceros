using Model;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace VuelosACeniceros
{
    public partial class Comprar1 : Form
    {
        
        Persona person = new Persona();
        string [] lista = Entrada.aeropuertos.Lista_aeropuertos.ToArray();
        string origen = "";
        string destino = "";
        string fechaSalida = "";
        string fechaVuelta = "";
        string copiaOrigen = "";
        string copiaDestino = "";
        string copiaSalida = "";
        string copiaVuelta = "";
        Vuelo v = null;
        Vuelo v2 = null;
        Billete billete = null;

        public Comprar1()
        {
            InitializeComponent();
            copiaOrigen = lbOrigen.Text;
            copiaDestino = lbDestino.Text;
            copiaSalida = lbIda.Text;
            copiaVuelta = lbVuelta.Text;

        }

        public Comprar1(Persona persona)
        {
            
            
            InitializeComponent();
       
            copiaOrigen = lbOrigen.Text;
            copiaDestino = lbDestino.Text;
            copiaSalida = lbIda.Text;
            copiaVuelta = lbVuelta.Text;

        }

        // Carga el formulario con los valores vacíos y los combos con la lista de aeropuertos
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();
            cmbOrigen.Items.AddRange(lista);
            cmbDestino.Items.AddRange(lista);
            cmbOrigen.SelectedItem = null;
            cmbDestino.SelectedItem = null;
            DateTime today = DateTime.Today;
            monthCalendar1.SelectionStart = today;
            monthCalendar1.SelectionEnd = today;
            origen = "";
            destino = "";
            fechaSalida = "";
            fechaVuelta = "";
            monthCalendar1.MinDate = DateTime.Today;
            btComprar.Text = "COMPRAR BILLETE";
          
        }

        // Si hay origen, habilita destino
        private void cmbOrigen_SelectedItemChanged(object sender, EventArgs e)
        {
            
            lbOrigen.Text = copiaOrigen + " " + cmbOrigen.SelectedItem.ToString();
            lbOrigen.Visible = true;
            origen = cmbOrigen.SelectedItem.ToString();
            if (cmbOrigen.SelectedIndex != -1)
            {

                cmbDestino.Enabled = true;
                

            }
        }

        private void cmbDestino_SelectedItemChanged(object sender, EventArgs e)
        {
            lbDestino.Text = copiaDestino + " " + cmbDestino.SelectedItem.ToString();
            lbDestino.Visible = true;
            destino = cmbDestino.SelectedItem.ToString();
            
            
        }

        private void cmbOrigen_Leave(object sender, EventArgs e)
        {
            cmbDestino.Items.Clear();
            cmbDestino.Items.AddRange(lista);
            cmbDestino.Items.Remove(cmbOrigen.Text);
            cmbOrigen.Text = origen;

        }

        private void cmbDestino_Leave(object sender, EventArgs e)
        {
            cmbOrigen.Items.Clear();
            cmbOrigen.Items.AddRange(lista);
            cmbOrigen.Items.Remove(cmbDestino.Text);
            cmbDestino.Text = destino;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionRange.Start != null)
            {
                lbIda.Visible = true;
                lbIda.Text = copiaSalida + " " + monthCalendar1.SelectionRange.Start.ToLongDateString();
                fechaSalida = monthCalendar1.SelectionRange.Start.ToLongDateString();
                monthCalendar2.MinDate = monthCalendar1.SelectionRange.Start;
                cmbOrigen.Text = origen;
                cmbDestino.Text = destino;
               
            }
            if (lbOrigen.Text!=string.Empty && lbDestino.Text != string.Empty && lbIda.Text != string.Empty && lbTitulo4.Visible == false)
            {
                btComprar.BackColor = Color.Blue;
                btComprar.ForeColor = Color.White;
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar2.SelectionRange.Start != null) 
            {
                lbVuelta.Visible = true;
                lbVuelta.Text = copiaVuelta + " " + monthCalendar2.SelectionRange.Start.ToLongDateString();
                fechaVuelta = monthCalendar2.SelectionRange.Start.ToLongDateString();
                cmbOrigen.Text = origen;
                cmbDestino.Text = destino;
                
            }
            if (lbOrigen.Text != string.Empty && lbDestino.Text != string.Empty && lbIda.Text != string.Empty && lbVuelta.Text != string.Empty)
            {
                btComprar.BackColor = Color.Blue;
                btComprar.ForeColor = Color.White;
            }

        }
        private void btComprar_Click(object sender, EventArgs e)
        {
          
            if (btComprar.BackColor==Color.Blue)
            {
                            
                v = new Vuelo(origen, destino, monthCalendar1.SelectionRange.Start);
                if (monthCalendar2.Visible)
                {
                    v2 = new Vuelo(destino, origen, monthCalendar2.SelectionRange.Start);

                }
                Comprar2 f = new Comprar2(v, v2);
                f.ShowDialog();
                

               

                if (f.Vacio == false)
                {
                    person = new Persona(f.Nombre, f.Apellidos, f.Dni, f.Direccion);
                    lbComprador.Text = "Nombre: " + person.Nombre + "\n" + "Apellidos: " + person.Apellidos + "\n" + "DNI: " + person.Dni + "\n" + "Dirección: " + person.Direccion;
                    lbCompra.Visible = true;
                    lbComprador.Visible = true;
                    btInfo.Visible = true;
                    if (v2 != null)
                    {
                        billete = new Billete(person,v, v2);
                        billete.I_v = true;
                        
                    }
                    else
                    {
                        billete = new Billete(person, v);
                        billete.I_v = false;
                        
                    }
                    Entrada.billetes.Anadir_billete(billete);
                }
            }

            }
                     
        // Habilita el calendario de fecha de vuelta y permite desactivarlo cambiando el nombre
        private void btVuelta_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedItem != null || cmbDestino.SelectedItem != null)
            {
                if (btVuelta.Text.Equals("SELECCIONAR VUELTA"))
                {
                    btVuelta.Text = "SIN VUELTA";
                    monthCalendar2.Visible = true;
                    lbTitulo4.Visible = true;
                    
                }
                else
                {
                    btVuelta.Text = "SELECCIONAR VUELTA";
                    monthCalendar2.Visible = false;
                    lbTitulo4.Visible = false;
                    lbVuelta.Visible = false;
                    lbVuelta.Text = copiaVuelta;
                    fechaVuelta = "";
                }

            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                string cuerpo = "Por favor, seleccione un vuelo de ida";
                string cabecera = "Error en la selección de vuelo";
                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBox.Show(cuerpo, cabecera, botones, icono);

            }
        }

        // Muestra la información si hay billete comprado
        private void btInfo_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;

            MessageBoxButtons botones = MessageBoxButtons.OK;
            
            if(billete!=null) 
            {
             if (billete.I_v)
                {
                    cuerpo = billete.Mostrar();
                }
                else
                {
                    cuerpo = billete.MostrarIda();
                }

            }
            else
            {
                cuerpo = "No se ha comprado billete";
            }
            cabecera = "Datos del billete";
            icono = MessageBoxIcon.Information;
            MessageBox.Show(cuerpo, cabecera, botones, icono);

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }

}
