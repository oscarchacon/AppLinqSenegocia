using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqSenegocia.Model
{
    public class Region : Base
    {
        public Region() : base() { }

        public Region(int Identificador, string Nombre, bool Activo) : base(Identificador, Nombre, Activo) { }
    }
}
