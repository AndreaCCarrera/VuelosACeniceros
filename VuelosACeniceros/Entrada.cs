using Model;
using Business;
using System;
using System.Drawing;
using System.Windows.Forms;
using VuelosACeniceros.Administrador;
using VuelosACeniceros.Cliente;

namespace VuelosACeniceros
{
    
    public partial class Entrada : Form
    {
        //Objetos estáticos para poder cargar los datos desde todos los formularios
        public static Personas personas = new Personas();
        public static Billetes billetes = new Billetes(Entrada.personas);
        public static Persona persona = new Persona();
        public static Aeropuertos aeropuertos = new Aeropuertos();
        private string rutaOjo1 = "ojo1.png";
        private string rutaOjo2 = "ojo2.png";
        public string nuevaContrasena ="";


        public Entrada()
        {
            InitializeComponent();
            txtDni.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            
        }
        private void btEntrar_Click(object sender, EventArgs e)
        {

            if (btEntrar.BackColor == Color.Blue)
            {
                if ((txtDni.Text == "admin") && (txtContrasena.Text == "admin"))
                {
                    new MenuAdmin().Show();
                    this.Close();
                }

                else if (personas.Esta_dni(txtDni.Text))
                {
                    if (personas.Obtener_password(txtDni.Text).Equals(txtContrasena.Text))
                    {
                        persona = personas.Obtener_persona(txtDni.Text);
                        if (persona.ComprobarContrasena() && txtContrasena.Text.Equals(personas.Obtener_password(txtDni.Text)))
                        {

                            
                            new MenuCliente().Show();
                            this.Close();
                           
                        }
                        else
                        {
            
                            CambiarContrasena cambiarContrasenaForm = new CambiarContrasena(persona);
                            cambiarContrasenaForm.ShowDialog();

                            string nuevaContrasena = cambiarContrasenaForm.Contrasena;

                            personas.Cambiar_password(persona.Dni, nuevaContrasena);
                            persona.NuevaContrasena = true;
                        }
                    }
                    else
                    {
                        string cuerpo = "El usuario o contraseña son incorrectos";
                        string cabecera = "Error de acceso";
                        MessageBoxIcon icono = MessageBoxIcon.Error;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(cuerpo, cabecera, botones, icono);
                    }
                }
                else
                {
                    string cuerpo = "El usuario o contraseña son incorrectos";
                    string cabecera = "Error de acceso";
                    MessageBoxIcon icono = MessageBoxIcon.Information;
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show(cuerpo, cabecera, botones, icono);

                }


            }
            else
            {
                lbAviso.Text = "Por favor, rellene los campos";
                lbAviso.Visible = true;    
            }
    }

        //Método para activar por color el botón de entrar si todos los campos están cumplimentados
        private void NewTextChanged(object sender, EventArgs e)
        {
            if ((txtContrasena.Text != string.Empty) && (txtDni.Text != string.Empty))
            {
                btEntrar.BackColor = Color.Blue;
                btEntrar.ForeColor = Color.White;
                lbAviso.Visible = false;
            }
            else
            {
                btEntrar.ResetBackColor();
                btEntrar.ResetForeColor();
            }
        }

        //Método para cambiar la visibilidad de la contraseña a partir de la imagen del ojo
        private void Ojo_Click(object sender, EventArgs e)
        {

            if (picOjo.ImageLocation == rutaOjo1)
            {
                txtContrasena.PasswordChar = '\0';
                picOjo.ImageLocation = rutaOjo2;
                picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                txtContrasena.PasswordChar = '*';
                picOjo.ImageLocation = rutaOjo1;
                picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void Entrada_Click(object sender, EventArgs e)
        {
            lbAviso.Visible =false;
        }
    }
}
