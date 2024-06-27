using System;
using System.Collections.Generic;


namespace Business
{
    public class Aeropuertos
    {

        private List<string> lista_aeropuertos;

        public Aeropuertos(List<string> lista_aeropuertos)
        {
            this.lista_aeropuertos = lista_aeropuertos;
        }

        public Aeropuertos()
        {
            this.lista_aeropuertos = new List<string>();
            Rellenar();
        }

        public List<string> Lista_aeropuertos
        {
            get => lista_aeropuertos;
            set => lista_aeropuertos = value;
        }

        public bool AnadirAeropuerto(string aeropuerto)
        {
            Boolean anadido = true;

            foreach (String aero in lista_aeropuertos)
            {
                if (aero.Equals(aeropuerto))
                {
                    anadido = false;
                    break;
                }
            }

            if (anadido==true)
            {
             lista_aeropuertos.Add(aeropuerto);
                anadido = true;
            }
             return anadido;
        }

        public bool EliminarAeropuerto(string aeropuerto)
        {
            Boolean eliminado = false;

            foreach (String aero in lista_aeropuertos)
            {
                if (aero.Equals(aeropuerto))
                {
                    lista_aeropuertos.Remove(aeropuerto);
                    eliminado = true;
                    break;
                }
            }
           
            return eliminado;
        }

        // Crear aeropuertos de prueba llamando al método desde el constructor vacío
        public void Rellenar()
        {

            lista_aeropuertos.Add("Bilbao");
            lista_aeropuertos.Add("San Francisco");
            lista_aeropuertos.Add("Atenas");
            lista_aeropuertos.Add("Londres");
        }
    }
}
