using Business;
using System;
using System.Windows.Forms;

namespace VuelosACeniceros.Administrador
{
    public partial class MenuAdmin : Form
    {
        private Personas personas = new Personas();
        private Billetes billetes = new Billetes();

        public MenuAdmin()
        {
            InitializeComponent();
        }

        public MenuAdmin(Personas personas, Billetes billetes)
        {   
            this.personas = personas;
            this.billetes = billetes;
            InitializeComponent();
        }

        // Abre el formulario de administrar clientes
        private void btClientes_Click(object sender, EventArgs e)
        {
            new AdminClientes().ShowDialog();
        }

        //Abre el formulario de administrar aeropuertos
        private void btAeropuertos_Click(object sender, EventArgs e)
        {
            new VistaAeropuertos().ShowDialog();
        }

        //Abre el formulario con la gráfica de vuelos por cliente
        private void btVerBilletes_Click(object sender, EventArgs e)
        {
            new VerBillete().ShowDialog();
        }

        //Abre el formulario de modificar billetes
        private void btModificar_Click(object sender, EventArgs e)
        {
            new ModificarBillete().ShowDialog();    
        }

        // Gestiona la carga de documentos
        private void btCargar_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFichero.Text = openFile.FileName;
            }
            else
            {
                txtFichero.Text = "ERROR";
            }
        }

        // Gestiona guardar en documento
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txtFichero.Text = saveFile.FileName;
            }
            else
            {
                txtFichero.Text = "ERROR";
            }

        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;

            cuerpo = "¿Está seguro de que desea salir?";
            cabecera = "Cerrar sesión";
            icono = MessageBoxIcon.Exclamation;
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            result = MessageBox.Show(cuerpo, cabecera, botones, icono);

            if (result == DialogResult.OK)
            {
                this.Close();

            }
           
        }

        
    }
}
