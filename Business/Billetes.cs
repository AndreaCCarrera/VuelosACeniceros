using Model;
using System;
using System.Collections.Generic;

namespace Business
{
    public class Billetes
    {

        private List<Billete> lista_billetes;

        public List<Billete> Lista_billetes { get => lista_billetes; set => lista_billetes = value; }

        public Billetes()
        {
            this.lista_billetes = new List<Billete>();

        }
        public Billetes(Personas lista)
        {
            this.lista_billetes = new List<Billete>();
            this.Rellenar(lista);
        }
        public Billetes(List<Billete> lista_billetes)
        {
            this.lista_billetes = lista_billetes;
        }

        // Buscar billete por ID
        public Billete Buscar_id(int id)
        {
            Billete billete = null;
            foreach (Billete b in lista_billetes)
            {

                if (b.Id == id)
                {

                    billete = b;
                    break;
                }

            }

            return billete;
        }

        public bool Anadir_billete(Billete b)
        {
            Boolean anadido = false;

            if (b != null)
            {
                lista_billetes.Add(b);
                anadido = true;
            }


            return anadido;
        }

        // Devolver lista de billetes del mismo DNI
        public Billetes Buscar_dni(String dni)
        {
            Boolean vacia = true;
            Billetes billetes = new Billetes();
            foreach (Billete b in lista_billetes)
            {

                if (b.Persona.Dni.Equals(dni))
                {
                    billetes.Anadir_billete(b);
                    vacia = false;
                }

            }

            if (vacia)
            {
                billetes = null;
            }

            return billetes;

        }

        // Buscar los vuelos del mismo DNI
        public List<Vuelo> Buscar_Vuelos(String dni)
        {
            Boolean vacia = true;
            List<Vuelo> vuelos = new List<Vuelo>();
            foreach (Billete b in lista_billetes)
            {

                if (b.Persona.Dni.Equals(dni))
                {
                    vuelos.Add(b.Ida);
                    vacia = false;
                    if (b.I_v)
                    {
                        vuelos.Add(b.Vuelta);
                    }
                }

            }

            if (vacia)
            {
                vuelos = null;
            }

            return vuelos;

        }

        // Sacar el DNI de la persona del billete
        public String Mostrar_dni(int id)
        {
            String dniCliente = string.Empty;
            foreach (Billete b in lista_billetes)
            {

                if (b.Id == id)
                {

                    dniCliente = b.Persona.Dni;
                    break;
                }

            }

            return dniCliente;
        }

        // Borrar todos los billetes de una misma persona por DNI
        public bool Eliminar_billete_dni(string dni)
        {
            Boolean eliminado = false;

            foreach (Billete billete in lista_billetes)
            {

                if (billete.Persona.Dni.Equals(dni))
                {
                    lista_billetes.RemoveAll(x => x.Persona.Dni == dni);
                    break;
                }
            }

            return eliminado;

        }

        //Obtener el número de vuelos de una persona
        public int Num_vuelos_p(string dni)
        {
            int numero = 0;

            foreach (Billete b in lista_billetes)
            {

                if (b.Persona.Dni.Equals(dni))
                {
                    numero++;
                }
            }

            return numero;
        }

        // Filtrar billetes por fecha
        public Billetes FiltrarFecha()
        {
            Boolean vacia = true;
            Billetes billetes = new Billetes();
            DateTime fechaActual = DateTime.Now;
            int result = 0;
            foreach (Billete b in lista_billetes)
            {
                result = DateTime.Compare(b.Ida.Fecha, fechaActual);
                if (result > 0)
                {
                    billetes.Anadir_billete(b);
                    vacia = false;
                }
            }

            if (vacia)
            {
                billetes = null;
            }

            return billetes;

        }

        public bool ModificarBillete(Boolean vueltaSi, int id, Vuelo v1, Vuelo v2, Persona p)
        {
            Boolean modificado = false;

            foreach (Billete b in lista_billetes)
            {

                if (b.Id == id)
                {
                    b.Persona = p;
                    b.Ida = v1;

                    if (vueltaSi)
                    {
                        b.Vuelta = v2;
                        b.I_v = true;
                    }
                }
                modificado = true;
            }

            return modificado;
        }

        // Crear billetes de prueba para la aplicación, cargándolas desde el constructor vacío
        public void Rellenar(Personas lista)
        {

            DateTime fecha = new DateTime(2023, 12, 31, 15, 30, 0);
            Vuelo v1 = new Vuelo("Bilbao", "San Francisco", fecha);
            Vuelo v2 = new Vuelo("Londres", "Bilbao", DateTime.Now);
            Vuelo v3 = new Vuelo("Atenas", "San Francisco", fecha);
            Vuelo v4 = new Vuelo("Bilbao", "Londres", DateTime.Now);
            Vuelo v5 = new Vuelo("San Francisco", "Bilbao", fecha);
            Vuelo v = v1;

            foreach (Persona persona in lista.Lista_personas)
            {

                Billete b = new Billete(persona, v);
                Anadir_billete(b);
                if (v == v1)
                {
                    v = v2;
                }
                else if (v == v2)
                {
                    v = v3;
                }
                else if (v == v3)
                {
                    v = v4;
                }
                else
                {
                    v = v5;
                }
            }

            foreach (Persona persona in lista.Lista_personas)
            {

                Billete b = new Billete(persona, v);
                Anadir_billete(b);
                if (v == v1)
                {
                    v = v2;
                }
                else if (v == v2)
                {
                    v = v3;
                }
                else if (v == v3)
                {
                    v = v4;
                }
                else
                {
                    v = v5;
                }
            }

        }
       
    }

}