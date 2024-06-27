using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VuelosACeniceros.Cliente
{
    public partial class CambiarContrasena : Form
    {
        private string contrasena;
        private Persona persona;
        private string rutaOjo1 = "ojo1.png";
        private string rutaOjo2 = "ojo2.png";

        public string Contrasena { get => contrasena; set => contrasena = value; }
        public Persona Persona { get => persona; set => persona = value; }

        public CambiarContrasena()
        {
            InitializeComponent();
            txtNueva.Text = string.Empty;
            txtRepite.Text = string.Empty;
            lbAviso.Visible = false;
            lbAviso.ForeColor = Color.Black;

        }

        public CambiarContrasena(Persona persona)
        {
            this.persona = persona;
            InitializeComponent();

            txtNueva.Text = string.Empty;
            txtRepite.Text = string.Empty;

        }


        // Método para activar o desactivar por color el botón de Actualizar
        private void NewTextChange(object sender, EventArgs e)
        {
            if((txtNueva.Text!= string.Empty)&& (txtRepite.Text != string.Empty))
            {
                btActualizar.BackColor = Color.Blue;
                btActualizar.ForeColor = Color.White;
                lbAviso.Visible = false;
            }
            else
            {
                btActualizar.ResetBackColor();
                btActualizar.ResetForeColor();

            }

        }

        // Método para cambiar la visibilidad de la contraseña
        private void Ojo_Click(object sender, EventArgs e)
        {

            if (picOjo.ImageLocation == rutaOjo1)
            {
                txtAntigua.PasswordChar = '\0';
                picOjo.ImageLocation = rutaOjo2;
                picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                txtAntigua.PasswordChar = '*';
                picOjo.ImageLocation = rutaOjo1;
                picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if(btActualizar.BackColor == Color.Blue) { 
              if (btActualizar.Text.Equals("ACTUALIZAR")) 
              { 
                if (txtRepite.Text.Equals(txtNueva.Text)==false)
                {
                    lbAviso.ForeColor = Color.Red;
                    lbAviso.Text = "Las contraseñas introducidas no son iguales";
                    lbAviso.Visible = true;
                    btActualizar.ResetBackColor();
                    btActualizar.ResetForeColor();
                    }
                else if (txtNueva.Text.Equals(txtAntigua.Text))
                {
                    lbAviso.ForeColor = Color.Red;
                    lbAviso.Text = "No se puede poner la contraseña anterior";
                    lbAviso.Visible = true;
                    btActualizar.ResetBackColor();
                    btActualizar.ResetForeColor();
                    }
                else
                {
                    contrasena = txtNueva.Text;
                    lbAviso.Text = "Contraseña cambiada correctamente";
                    lbAviso.ForeColor = Color.Blue;
                    lbAviso.Visible = true;
                    btActualizar.BackColor = Color.Blue;
                    btActualizar.ForeColor = Color.White;
                    btActualizar.Text = "ACEPTAR";

                }
            
              }
              else
              {
                 this.Close();
              }

            }
            else
            {
                lbAviso.ForeColor = Color.Red;
                lbAviso.Text = "Faltan campos por rellenar";
                lbAviso.Visible = true;
            }
        }

        private void CambiarContrasena_Click(object sender, EventArgs e)
        {
            lbAviso.Visible = false;
        }
    }
}
