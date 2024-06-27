using System;
using Model;
using System.Windows.Forms;

namespace VuelosACeniceros.Cliente
{
    public partial class BilleteIV : Form
    {
        private Billete billete;
        public BilleteIV()
        {
            InitializeComponent();
        }

        public BilleteIV(Billete billete)
        {
            this.billete = billete;
            InitializeComponent();
            lbBilleteI.Text = billete.Id.ToString();
            lbOrigenI.Text = billete.Ida.Origen;
            lbDestinoI.Text = billete.Ida.Destino;
            lbFechaI.Text = billete.Ida.Fecha.ToString();
            lbNombreI.Text = billete.Persona.Nombre +" "+billete.Persona.Apellidos;
            lbDniI.Text = billete.Persona.Dni;
            lbBilleteV.Text = billete.Id.ToString();
            lbOrigenV.Text = billete.Vuelta.Origen;
            lbDestinoV.Text = billete.Vuelta.Destino;
            lbFechaV.Text = billete.Vuelta.Fecha.ToString();
            lbNombreV.Text = billete.Persona.Nombre + " " + billete.Persona.Apellidos;
            lbDniV.Text = billete.Persona.Dni;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
