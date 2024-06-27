using System;

namespace Model
{
    public class Billete
    {
        private int id;
        private Persona persona;
        private Vuelo ida;
        private Vuelo vuelta;
        private bool i_v;
        private static int contador = 1;

        public Persona Persona { get => persona; set => persona = value; }
        public Vuelo Ida { get => ida; set => ida = value; }
        public Vuelo Vuelta { get => vuelta; set => vuelta = value; }
        public bool I_v { get => i_v; set => i_v = value; }
        public int Id { get => id; }

        public Billete(Persona persona, Vuelo ida, Vuelo vuelta)
        {
            this.persona = persona;
            this.ida = ida;
            this.vuelta = vuelta;
            this.i_v = true;
            this.id= contador;
            contador++;
 
        }

        public Billete(Persona persona, Vuelo ida)
        {
            this.persona = persona;
            this.ida = ida;
            this.i_v = false;
            this.id= contador;
            contador++;

        }

        public Billete(Vuelo ida, Vuelo vuelta)
        {
            this.ida = ida;
            this.vuelta = vuelta;
            this.i_v = true;
            this.id= contador;
            contador++;

        }

        public Billete(Vuelo ida)
        {
            this.ida = ida;
            this.id = contador;
            contador++;

        }

        public string Mostrar()
        {
            return "Id billete: " + this.id + "\n " + this.persona.Mostrar() + "\n " + this.ida.Mostrar() + " \n" + this.vuelta.Mostrar();
        }

        public string MostrarIda()
        {
            return "Id billete: " + this.id + "\n " + this.persona.Mostrar() + "\n " + this.ida.Mostrar();
        }
    }


}
   
