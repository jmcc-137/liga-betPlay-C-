using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIGA.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();


        public Team(int id, string? name, string? city)
        {
            Id = id;
            Name = name;
            City = city;
        }
        public Team() { }

        public override string ToString()
        {
            return $"{Name} From {City} (ID: {Id})";
        }
    }
}