using AppLinqSenegocia.Model;
using AppLinqSenegocia.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqSenegocia
{
    class Program
    {
        static void Main(string[] args)
        {
            Region[] regiones = NegocioStatic.CargaRegiones().ToArray();

            var _regiones = from _r in regiones
                            select _r;

            foreach(var l_r in _regiones)
            {
                Console.WriteLine(l_r.Nombre);
            }

            Comuna[] comunas = NegocioStatic.CargaComunas().ToArray();

            var _comunas = from _c in comunas
                            select _c;

            foreach (var l_c in _comunas)
            {
                Console.WriteLine(l_c.Nombre);
            }

            Persona[] personas = NegocioStatic.CargaPersonas().ToArray();

            var _personas = from _p in personas
                            join _r in regiones on _p.IdRegion equals _r.Identificador
                            join _c in comunas on _p.IdComuna equals _c.Identificador
                            select new { NomprePersona = _p.Nombre, NombreRegion = _r.Nombre, NombreComuna = _c.Nombre };

            Console.WriteLine(personas.LongCount());

            foreach(var l_p in _personas)
            {
                Console.WriteLine("Nombre de Persona:"+l_p.NomprePersona+" , Region: "+ l_p.NombreRegion+" , Comuna: "+l_p.NombreComuna);
            }

        }
    }
}
