using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqSenegocia.Model
{
    public class Persona : Base
    {
        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public int IdRegion { get; set; }

        public int IdComuna { get; set; }

        public Region Region { get; set; }

        public Comuna Comuna { get; set; }

        public Persona() { }

        public Persona(int Identificador, string Nombre, bool Activo, string Direccion, int IdRegion, int IdComuna) : base(Identificador, Nombre, Activo)
        {
            this.Direccion = Direccion;
            this.IdRegion = IdRegion;
            this.IdComuna = IdComuna;
        }

    }
}
