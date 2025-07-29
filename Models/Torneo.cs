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

        public string? Pais { get; set; }


        public List<Team> equiposParticipantes { get; set; } = new List<Team>();
        public static List<Torneo> torneos { get; set; } = new List<Torneo>();
        public Torneo(int id, string? nombre, string? pais)
        {
            ID = id;
            Nombre = nombre;
            Pais = pais;
        }
        public override string ToString()
        {
            return $"{ID}, {Nombre}, {Pais}, equipos Inscritos: {equiposParticipantes.Count}";
        }
        public Torneo() { }
    }
    
}