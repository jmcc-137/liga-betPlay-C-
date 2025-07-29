using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using LIGA.Models;
using LIGA.funciones_Equipo;
namespace LIGA.funciones_Equipo
{
    public class CrearTorneo
    {
        public static List<Torneo> torneos { get; set; } = new List<Torneo>();
        public void Crear()
        {
            int numero;
            string id;
            do
            {
                
                Console.WriteLine("Crear Torneo");

                Console.WriteLine("ID del torneo: ");
                id = Console.ReadLine() ?? "";
                Console.WriteLine("Nombre del Torneo: ");
                string nombre = Console.ReadLine() ?? "";
                Console.WriteLine("Ingrese el pais donde se realiza: ");
                string pais = Console.ReadLine() ?? "";
                if (int.TryParse(id, out numero))
                {
                    Console.WriteLine("ID ACEPTADO");
                    Torneo NewTorneo = new Torneo(numero, nombre, pais);
                    torneos.Add(NewTorneo);
                    Console.WriteLine(NewTorneo.ToString());
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ID Invalido");
                }
            } while (!int.TryParse(id, out numero));
        }
  

    }
    
    
}