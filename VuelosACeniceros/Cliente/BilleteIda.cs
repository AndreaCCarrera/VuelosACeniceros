using System;
using Model;
using System.Windows.Forms;

namespace VuelosACeniceros.Cliente
{
 
    public partial class BilleteIda : Form
    {
        private Billete billete;
        public BilleteIda()
        {
            InitializeComponent();
        }

        public BilleteIda(Billete billete)
        {
            this.billete = billete;
            InitializeComponent();
            lbBillete.Text = billete.Id.ToString();
            lbOrigen.Text = billete.Ida.Origen;
            lbDestino.Text = billete.Ida.Destino;
            lbFecha.Text = billete.Ida.Fecha.ToString();
            lbNombre.Text = billete.Persona.Nombre + " " + billete.Persona.Apellidos;
            lbDni.Text = billete.Persona.Dni;

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
