using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqSenegocia.Model
{
    public class Comuna : Base
    {
        public int IdRegion { get; set; }

        public Comuna() : base() { }

        public Comuna(int IdRegion)
        {
            this.IdRegion = IdRegion;
        }

        public Comuna(int Identificador, string Nombre, bool Activo, int IdRegion) : base(Identificador, Nombre, Activo)
        {
            this.IdRegion = IdRegion;
        }
    }
}
