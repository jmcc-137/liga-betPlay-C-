using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIGA.funciones;
using LIGA.Menus;
using LIGA.Models;
namespace LIGA.funciones
{
    public class DeleteTorneo
    {
        public void Elimiar()
        {
            Console.WriteLine("Eliminar Por: ");
            Menu menu = new Menu();
            menu.SubMenu();
            int opcion = int.Parse(Console.ReadLine());
            Torneo torneoEdit = null;
            switch (opcion)
            {
                case 1:
                    foreach (var el in CrearTorneo.torneos)
                    {
                        Console.WriteLine($"{el.ID} - {el.Nombre}");
                    }

                    Console.WriteLine("Ingrese el ID: ");

                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        var torneo = CrearTorneo.torneos.FirstOrDefault(i => i.ID == id);
                        if (torneo != null)
                        {
                            CrearTorneo.torneos.Remove(torneo);
                            Console.WriteLine($"el torneo con el ID: {id} fue eliminado");

                            foreach (var el in CrearTorneo.torneos)
                            {
                                Console.WriteLine($"{el.ID} - {el.Nombre}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ID del torneo no encontrado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO encontrado");
                    }

                    break;
                case 2:
        
                    foreach (var el in CrearTorneo.torneos)
                    {
                        Console.WriteLine($"{el.ID} - {el.Nombre}");
                    }
                    Console.WriteLine("Ingrese el nombre a eliminar");
                    string DeleteName = Console.ReadLine();
                    var delete = CrearTorneo.torneos.FirstOrDefault(d => d.Nombre == DeleteName);
                    if (DeleteName != null)
                    {
                        Console.WriteLine("Encontrado");
                        CrearTorneo.torneos.Remove(delete);
                        Console.WriteLine("Eliminado");
                        foreach (var el in CrearTorneo.torneos)
                        {
                            Console.WriteLine($"{el.ID} - {el.Nombre}");
                        }

                    }
                    else
                    {
                        Console.WriteLine("NO encontrado");

                    }

                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opcion no encontrada");
                    break;
            }


        }

    }

}