using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIGA.Models
{
    public class Player : Person
    {
        public int Dorsal { get; set; }
        public string? Position { get; set; }

        public Player(int id, string? name, string? origen, string? email, int dorsal, string? position) : base(id, name, origen, email)
        {
            Id = id;
            Name = name;
            Origen = origen;
            Email = email;
            Dorsal = dorsal;
            Position = position;
        }
        public Player() { }
        public override string ToString()
        {
            return $"{Name} ({Position}) - Dorsal: {Dorsal}, Origen: {Origen}, Email:{Email}";
        }
    }
}