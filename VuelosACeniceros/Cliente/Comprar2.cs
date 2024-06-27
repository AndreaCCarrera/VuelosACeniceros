using Business;
using Model;
using System;
using System.Windows.Forms;

namespace VuelosACeniceros
{
    
    public partial class Comprar2 : Form
    {

        private string origen = "";
        private string destino = "";
        private string fechaIda = "";
        private string fechaVuelta = "";
        private string nombre = "";
        private string apellidos = "";
        private string direccion = "";
        private string dni = "";
        private Boolean vacio = true;
        public Vuelo vueloIda = new Vuelo();
        public Vuelo vueloVuelta = new Vuelo();


        public Comprar2()
        {
       
            InitializeComponent();
            
        }

        // Constructor con parámetros
        public Comprar2(string origen, string destino, string fechaIda, string fechaVuelta)
        {

            
            this.origen = origen;
            this.destino = destino;
            this.fechaIda = fechaIda;
            this.fechaVuelta = fechaVuelta;
   

            InitializeComponent();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }
        public bool Vacio { get => vacio; set => vacio = value; }

        public Comprar2(Vuelo v, Vuelo v2)
        {
            
            this.nombre = Entrada.persona.Nombre;
            this.apellidos = Entrada.persona.Apellidos;
            this.dni = Entrada.persona.Dni;
            this.direccion = Entrada.persona.Direccion;
            this.vueloIda = v;
            this.vueloVuelta = v2;
            InitializeComponent();
            txtNombre.Text = nombre;
            txtApellidos.Text = apellidos;
            txtDireccion.Text = direccion;
            txtDni.Text = dni;
            
        }

      // Valores por defecto a cargar el formulario
        private void Form2_Load(object sender, EventArgs e)
        {
            lbAviso.Visible = false;
            txtOrigen.Text = vueloIda.Origen;
            txtDestino.Text = vueloIda.Destino;
            txtIda.Text = vueloIda.Fecha.ToLongDateString();
            if (vueloVuelta != null && vueloVuelta.Fecha != null)
            {
                txtVuelta.Text = vueloVuelta.Fecha.ToLongDateString();
            }

        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtDni.Text))
            {

                lbAviso.Text = "Por favor, rellene todos los campos \n marcados con asterisco.";
                lbAviso.Visible = true;

            }
            else
            { 
                //Muestra los datos en un messegeBox y consulta si se quiere comprar o no
             
                if (vueloVuelta != null)
                {
                    cuerpo = Entrada.persona.Mostrar() + "\n" + vueloIda.Mostrar() + vueloVuelta.Mostrar();
                    cabecera = "¿Comprar vuelo?";
                    icono = MessageBoxIcon.Information;
                   
                }
                else
                {
                    cuerpo = Entrada.persona.Mostrar() + "\n" + vueloIda.Mostrar();
                    cabecera = "¿Comprar vuelo?";
                    icono = MessageBoxIcon.Information;
                   

                }
                MessageBoxButtons botones = MessageBoxButtons.OKCancel;
                result = MessageBox.Show(cuerpo, cabecera, botones, icono);
                if (result == DialogResult.OK)
                {
                    vacio = false;
                    this.Close();

                }
                else
                {
                    this.Close();
                }

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

        private void Comprar2_Click(object sender, EventArgs e)
        {
            lbAviso.Visible = false;
        }
    }
}
                    
                    
         

