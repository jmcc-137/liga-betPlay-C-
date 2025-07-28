using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIGA.funciones_Equipo;

namespace LIGA.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public List<Player> equipos { get; set; } = new List<Player>();


        public Team(int id, string? name, string? city, string? country)
        {
            ID = id;
            Name = name;
            City = city;
            Country = country; 
        }
        public Team() { }

        public override string ToString()
        {
            return $" EQUIPO: Nombre: {Name} de:{City} pais:{Country} (ID: {ID})";
        }
    }
}