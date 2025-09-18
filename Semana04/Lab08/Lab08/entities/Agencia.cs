using System;
using System.Collections.Generic;

namespace Lab08.entities
{
    class Agencia
    {
        public Agencia() {
            Inmuebles = new List<Inmueble>();
        }

        public String Codigo { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public String Telefono { get; set; }
        public List<Inmueble> Inmuebles { get; set; }
    }
}
