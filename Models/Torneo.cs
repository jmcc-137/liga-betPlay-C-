using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

using LIGA.funciones_Equipo;

namespace LIGA.Models
{

    public class Torneo
    {

        public int ID { get; set; }
        public string? Nombre { get; set; }



        public Torneo(int id, string? nombre)
        {
            ID = id;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return $"{ID}, {Nombre}";
        }
        public Torneo() { }
    }
    
}