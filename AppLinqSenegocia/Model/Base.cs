using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqSenegocia.Model
{
    public abstract class Base
    {
        public int Identificador { get; set; }

        public string Nombre { get; set; }

        public bool Activo { get; set; }

        public Base() { }

        public Base(int Identificador, string Nombre, bool Activo) {
            this.Identificador = Identificador;
            this.Nombre = Nombre;
            this.Activo = Activo;
        }
    }
}
