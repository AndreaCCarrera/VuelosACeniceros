using Model;
using System;
using System.Collections.Generic;


namespace Business
{
    public class Personas 
    {

        private List<Persona> lista_personas;

        public Personas()
        {
            this.lista_personas = new List<Persona>();
            this.Rellenar();
        }
        public Personas(List<Persona> lista_personas)
        {
            this.lista_personas = lista_personas;
        }

        public List<Persona> Lista_personas { get => lista_personas; set => lista_personas = value; }
    
       

        public bool Anadir_persona (Persona p)
        {

            Boolean anadido = false;

            if (p != null)
            {
                lista_personas.Add(p);
                anadido = true;
            }


            return anadido;
        }

        public bool Eliminar_persona(Persona p)
        {

            Boolean eliminado = false;

            if (p != null)
            {
            foreach(Persona persona in lista_personas)
                {
                    if (p.Dni.Equals(persona.Dni))
                    {
                        lista_personas.Remove(p);
                        eliminado = true;
                    }
                }
             
            }


            return eliminado;
        }

     
     // Devolver persona por DNI
        public Persona Obtener_persona(string dni)
        {
            Persona persona = new Persona();

            foreach (Persona p in lista_personas)
            {
                if (p.Dni.Equals(dni))
                {
                    persona = p;
                  
                }

            }
            return persona;
        }

        public bool Esta_dni(string dni)
        {
            Boolean esta = false;

            foreach (Persona p in lista_personas)
            {
                if (p.Dni.Equals(dni))
                {
                    esta = true;
                    break;
                }
            }

            return esta;
        }

        public string Obtener_password(string dni)
        {

            string contrasena = string.Empty;

            foreach (Persona p in lista_personas)
            {
                if (p.Dni.Equals(dni))
                {
                    contrasena = p.Password;

                }

            }


            return contrasena;
        }

        public void Cambiar_password(string dni, string password)
        {

            foreach (Persona p in lista_personas)
            {
                if (p.Dni.Equals(dni))
                {
                    p.Password = password;
                    p.NuevaContrasena = true;

                }

            }

        }



        // Método para rellenar automáticamente una lista de personas de prueba desde el constructor
        public void Rellenar() {
            Persona p1 = new Persona("Vilma", "Picapiedra", "11111111A", "Calle Acequia", "1111");
            Persona p2 = new Persona("Pato", "Lucas", "22222222B", "Avenida Charca", "2222");
            Persona p3 = new Persona("Luna", "Lovegood", "33333333C", "Callejón Djagon", "3333");
            Persona p4 = new Persona("Gandalf", "El Gris", "44444444D", "Calle Acequia", "4444");
            Persona p5 = new Persona("Snoopy", "The Dog", "55555555E", "Caseta del Jardín", "5555");
            this.Lista_personas.Add(p1);
            this.Lista_personas.Add(p2);
            this.Lista_personas.Add(p3);
            this.Lista_personas.Add(p4);
            this.Lista_personas.Add(p5);
        }
      
    }
}
