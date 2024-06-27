using Model;
using Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VuelosACeniceros.Cliente
{
    public partial class MenuCliente : Form
    {   
 

        public MenuCliente()
        {
            InitializeComponent();
            lbUsuario.Text += Entrada.persona.Nombre + " " + Entrada.persona.Apellidos;
        }


        // Abre el formulario de comprar
        private void btComprar_Click(object sender, EventArgs e)
        {
            new Comprar1().ShowDialog();
        }

        // Activa el botón de ver vuelo si hay datos en el textBox del id
        private void txtVuelo_TextChanged(object sender, EventArgs e)
        {
            if (txtVuelo.Text != string.Empty)
            {
                btVerVuelo.BackColor = Color.Blue;
                btVerVuelo.ForeColor = Color.White;

            }
            else
            {
                btVerVuelo.ResetBackColor();
                btVerVuelo.ResetForeColor();

            }
        }

        private void btVerVuelo_Click(object sender, EventArgs e)
        {
            
            if (btVerVuelo.BackColor == Color.Blue) { 
            
            Billete billeteCliente=Entrada.billetes.Buscar_id(Int32.Parse(txtVuelo.Text));
 
            if ((billeteCliente != null)&&(billeteCliente.Persona.Dni.Equals(Entrada.persona.Dni)))
                { 

              if(billeteCliente.Vuelta!=null) 
                {
                    new BilleteIV(billeteCliente).ShowDialog();
                }
                else
                {
                    new BilleteIda(billeteCliente).ShowDialog();
                }
            }
            else
            {
                    lbAviso.Text = "No existe el billete indicado";
                    lbAviso.Visible = true;
                }

            }
            else
            {
                    lbAviso.Text = "Por favor, indique el id";
                    lbAviso.Visible = true;
            }
        }

        // Abre el formulario de histórico
        private void btHistorico_Click(object sender, EventArgs e)
        {
            Billetes billetesCliente = new Billetes();
           
            billetesCliente = Entrada.billetes.Buscar_dni(Entrada.persona.Dni);
            

            if (billetesCliente != null)
            {
                new Historico().ShowDialog();
               
            
            }
            else
            {
                lbAviso.Text = "No tienes vuelos que mostrar";
                lbAviso.Visible = true;

            }
            
        }

        // Verificar si el carácter introducido es un dígito
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //Resetea los label de aviso
        private void MenuCliente_Click(object sender, EventArgs e)
        {
            lbAviso.Visible = false;
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;

            cuerpo = "¿Está seguro de que desea salir?";
            cabecera = "Cerrar sesión";
            icono = MessageBoxIcon.Information;
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            result = MessageBox.Show(cuerpo, cabecera, botones, icono);

            if (result == DialogResult.OK)
            {
                this.Close();

            }
        }

       
    }
}
