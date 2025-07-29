using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIGA.Models
{
    public class Tec : Person
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Puesto { get; set; }
        public Team Equipo { get; set; }

        public Tec(int id, string? nombre, string? puesto, string? origen, string? email, Team equipo) : base(id, nombre, origen, email)
        {
            ID = id;
            Nombre = nombre;
            Puesto = puesto;
            Origen = origen;
            Email = email;
            Equipo = equipo;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Puesto: {Puesto}, Nombre: {Nombre}, equipo: {Equipo.Name} ,origen: {Origen}, Email: {Email}";
        }
      
    }
}