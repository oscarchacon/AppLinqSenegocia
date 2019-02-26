using AppLinqSenegocia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppLinqSenegocia.Negocio
{
    public static class NegocioStatic
    {
        public static List<Region> CargaRegiones()
        {
            List<Region> OutRegiones = new List<Region>();
            Region r1 = new Region(1, "Tarapaca", true);
            Region r2 = new Region(2, "Antofagasta", true);
            Region r3 = new Region(3, "Atacama", true);
            Region r4 = new Region(4, "Coquimbo", true);
            Region r15 = new Region(15, "Arica y Parinacota", true);
            Region r5 = new Region(5, "Valparaiso", true);

            OutRegiones.Add(r1);
            OutRegiones.Add(r2);
            OutRegiones.Add(r3);
            OutRegiones.Add(r4);
            OutRegiones.Add(r5);
            OutRegiones.Add(r15);

            return OutRegiones;
        }
        public static List<Comuna> CargaComunas()
        {
            List<Comuna> OutComunas = new List<Comuna>();
            Comuna c1 = new Comuna(1,"Arica", true, 15);
            Comuna c2 = new Comuna(2,"Putre", true, 15);
            Comuna c3 = new Comuna(3, "Iquique", true, 1);
            Comuna c4 = new Comuna(4, "Alto Hospicio", true, 1);
            Comuna c5 = new Comuna(5, "Antofagasta", true, 2);
            Comuna c6 = new Comuna(6, "Calama", true, 2);
            Comuna c7 = new Comuna(7, "Copiapo", true, 3);
            

            OutComunas.Add(c1);
            OutComunas.Add(c2);
            OutComunas.Add(c3);
            OutComunas.Add(c4);
            OutComunas.Add(c5);
            OutComunas.Add(c6);
            OutComunas.Add(c7);

            return OutComunas;
        }

        public static List<Persona> CargaPersonas()
        {
            List<Persona> OutPersonas = new List<Persona>();

            Persona p1 = new Persona(1, "Pedro", true, "Av 1 123", 15, 1);
            Persona p2 = new Persona(2, "Juan", true, "Av 2 456", 15, 2);
            Persona p3 = new Persona(3, "Diego", true, "Av 3 789", 1, 3);
            Persona p4 = new Persona(4, "Ana", true, "Av 4 321", 1, 3);
            Persona p5 = new Persona(5, "Maria", true, "Av 5 654", 1, 4);
            Persona p6 = new Persona(6, "Camila", true, "Av 6 987", 2, 5);
            Persona p7 = new Persona(7, "Fernanda", true, "Av 7 147", 3, 7);
            Persona p8 = new Persona(8, "Jose", true, "Av 8 258", 3, 7);
            Persona p9 = new Persona(9, "Marco", true, "Av 9 369", 2, 6);
            Persona p10 = new Persona(10, "Segio", true, "Av 10 741", 15, 1);

            OutPersonas.Add(p1);
            OutPersonas.Add(p2);
            OutPersonas.Add(p3);
            OutPersonas.Add(p4);
            OutPersonas.Add(p5);
            OutPersonas.Add(p6);
            OutPersonas.Add(p7);
            OutPersonas.Add(p8);
            OutPersonas.Add(p9);
            OutPersonas.Add(p10);

            return OutPersonas;
        }
    }
}
