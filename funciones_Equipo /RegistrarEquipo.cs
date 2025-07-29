using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIGA.Models;

namespace LIGA.funciones_Equipo 
{
    public class RegistrarEquipo
    {
        public static List<Team> equipo { get; set; } = new List<Team>();
        public void Registrar()
        {
            int numero;
            string id;
            do
            {
                Console.WriteLine("Registrar equipo");

                Console.WriteLine("ingrese el ID del Equipo: ");
                id = Console.ReadLine() ?? "";
                if (!int.TryParse(id, out numero))
                {
                     Console.WriteLine("ID invalido");
                    
                    return;

                }
                else
                {
                Console.WriteLine("ID ACEPTADO");  
                Console.WriteLine("Nombre del equipo");
                var nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la ciudad");
                var ciudad = Console.ReadLine();
                Console.WriteLine("Ingrese el Pais");
                var pais = Console.ReadLine();
                
                Team NewEquipo = new Team(numero, nombre, ciudad, pais);
                equipo.Add(NewEquipo);
                Console.WriteLine(NewEquipo.ToString());
                }
                



            } while (!int.TryParse(id, out numero));

        }
    }
}