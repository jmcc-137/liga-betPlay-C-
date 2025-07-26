using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using LIGA.Models;
using LIGA.funciones;
using LIGA.Menus;
using System.Runtime.InteropServices;
namespace LIGA.funciones

{
    public class SearhTorneo
    {
        public void Buscar()
        {

            Menu menu = new Menu();
            Console.WriteLine("Escoje una opcion para buscar: ");
            menu.SubMenu();
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                     Console.WriteLine("Ingrese el ID: ");
                     int BuscarId = int.Parse(Console.ReadLine());
                     var encontrado = CrearTorneo.torneos.FirstOrDefault(t => t.ID == BuscarId);
                    if (encontrado != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Encontrado:");
                        Console.WriteLine($"ID: {encontrado.ID}, Nombre: {encontrado.Nombre}");
                    }
                    else
                    {
                         Console.WriteLine("No se encontró un torneo con ese ID.");
                    }

                    return;
            

                    case 2:
                    Console.WriteLine("Ingrese el nombre");
                    string buscar = Console.ReadLine();
                    var encontradoTitulo = CrearTorneo.torneos.Where(t => t.Nombre != null && t.Nombre.ToLower().Contains(buscar.ToLower())). ToList();
                    if (encontradoTitulo.Count > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("encontrados");
                        foreach (var torneo in encontradoTitulo)
                        {
                            Console.WriteLine(torneo);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("nombre no encontrado");
                    }

                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }

            
            
            


        }
    }
}