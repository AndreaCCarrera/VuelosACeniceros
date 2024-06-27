using System;

namespace Model
{
    public class Vuelo
    {

        private string origen;
        private string destino;
        private DateTime fecha;

        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Vuelo(string origen, string destino, DateTime fecha)
        {
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
        }

        public Vuelo()
        {
            this.origen = "";
            this.destino = "";
            this.fecha = new DateTime();
        }

        public string Mostrar()
        {
            return this.origen + "\n " + this.destino + "\n " + this.fecha;
        }
    }


}
