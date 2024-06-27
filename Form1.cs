using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelosACeniceros
{
    public partial class Form1 : Form
    {

        string[] lista = { "Bilbao", "Londres", "Atenas", "San Francisco" };
        string origen = "";
        string destino = "";
        string fechaSalida = "";
        string fechaVuelta = "";
        public Form1()
        {
            InitializeComponent();
        }

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
        }

        private void cmbOrigen_Leave(object sender, EventArgs e)
        {
            cmbDestino.Items.Clear();
            cmbDestino.Items.AddRange(lista);
            cmbDestino.Items.Remove(cmbOrigen.Text);
        }

        private void cmbDestino_Leave(object sender, EventArgs e)
        {
            cmbOrigen.Items.Clear();
            cmbOrigen.Items.AddRange(lista);
            cmbOrigen.Items.Remove(cmbDestino.Text);
        }

       
        private void btVuelta_Click(object sender, EventArgs e)
        {
            if(btVuelta.Text.Equals("SELECCIONAR VUELTA"))
            {
                btVuelta.Text = "SIN VUELTA";
                monthCalendar2.Visible = true;
            }
            else
            {
                btVuelta.Text = "SELECCIONAR VUELTA";
                monthCalendar2.Visible = false;
            }
            
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOrigen.Text = lbOrigen.Text+" "+cmbOrigen.SelectedItem.ToString();
            lbOrigen.Visible = true;
            origen = cmbOrigen.SelectedItem.ToString();
            if (cmbOrigen.SelectedIndex != -1)
            {

                cmbDestino.Enabled = true;
              
            }
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDestino.Text = lbDestino.Text+" "+cmbDestino.SelectedItem.ToString();
            lbDestino.Visible = true;
            destino= cmbDestino.SelectedItem.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionRange.Start != null)
            {
                lbIda.Visible = true;
                lbIda.Text = lbIda.Text + " " + monthCalendar1.SelectionRange.Start.ToLongDateString();
                fechaSalida = monthCalendar1.SelectionRange.Start.ToLongDateString();
                monthCalendar2.MinDate = monthCalendar1.SelectionRange.Start;
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar2.SelectionRange.Start != null) 
            {
                lbVuelta.Visible = true;
                lbVuelta.Text = lbVuelta.Text + " " + monthCalendar2.SelectionRange.Start.ToLongDateString();
                fechaVuelta = monthCalendar2.SelectionRange.Start.ToLongDateString();
            }
            
        }
        private void btComprar_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;

            if (origen.Equals("") || destino.Equals("")|| fechaSalida.Equals(""))
            {
                cuerpo = "Faltan datos";
                cabecera = "Error en la selección de vuelo";
                icono = MessageBoxIcon.Error;

            }
            else
            {

                if(fechaVuelta.Equals(""))
                {
                    cabecera = "Compra efectuada";
                    cuerpo = "Salida: " + fechaSalida + " desde " + origen + " a " + destino;
                    icono = MessageBoxIcon.Information;
                }
                else
                {
                    cabecera = "Compra efectuada";
                    cuerpo = "Ida: " + fechaSalida + " desde " + origen + "\n" + "Vuelta: " + fechaVuelta + " desde "+destino;
                    icono = MessageBoxIcon.Information;
                }
               
            }
            MessageBoxButtons botones = MessageBoxButtons.OK;
            MessageBox.Show(cuerpo, cabecera, botones, icono);
        }
    }
}
