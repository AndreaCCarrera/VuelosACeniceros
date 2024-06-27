using System;
using System.Runtime.Remoting.Messaging;

namespace Model
{
    public class Persona
    {

        private string nombre;
        private string apellidos;
        private string dni;
        private string direccion;
        private string password;
        private Boolean nuevaContrasena = false; // Para que la primera vez que entre le pida cambiar contraseña

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Password { get => password; set => password = value; }
        public bool NuevaContrasena { set => nuevaContrasena = value; }

        public Persona(string nombre, string apellidos, string dni, string direccion, string password)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.direccion = direccion;
            this.password = password;
        }

        public Persona(string nombre, string apellidos, string dni, string direccion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.direccion = direccion;
            this.password = dni;

        }

        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.dni = "";
            this.direccion = "";
            this.password = "";
        }

        public string Mostrar()
        {
            return this.nombre + "\n " + this.apellidos + "\n " + this.dni + "\n " + this.direccion;
        }

        public bool ComprobarContrasena() // Método para ver si es la primera vez que entra
        {
            return this.nuevaContrasena;
        }


        public string Generador_pass(int totalCaract) // Generador Random de password
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[totalCaract];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return (new String(stringChars));
        }

      

    }

}

