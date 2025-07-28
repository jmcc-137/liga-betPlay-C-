using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIGA.Menus;
using LIGA.funciones_Equipo;
using LIGA.Models;
using Microsoft.VisualBasic;
namespace LIGA.funciones_Equipo
{
    public class UpdateTorneo
    {
        public void Actualizar()
        {
            
            Menu menu = new Menu();
            menu.SubMenu();
            Console.WriteLine("Escoja la opcion Actualizar por:");
            int opcion = int.Parse(Console.ReadLine() ?? "");
            switch (opcion)
            {
                case 1:

                    foreach (var torneo in CrearTorneo.torneos)
                    {
                        Console.WriteLine($"ID: {torneo.ID} - Nombre:{torneo.Nombre}");
                    }
                    Console.WriteLine("Ingrese el id a editar del torneo: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        Console.WriteLine("Encontrado");
                        var Edit = CrearTorneo.torneos.FirstOrDefault(i => i.ID == id);
                        if (Edit != null)
                        {
                            Console.WriteLine("ingrese el nuevo ID: ");
                            if (int.TryParse(Console.ReadLine(), out int nuevoId))
                            {
                                Edit.ID = nuevoId;
                                foreach (var torneo in CrearTorneo.torneos)
                                {
                                    Console.WriteLine($"nombre: {torneo.Nombre} - ID: {torneo.ID} ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("id no aceptado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID invalido");
                    }


                    break;
                case 2:
            
                    foreach (var torneo in CrearTorneo.torneos)
                    {
                        Console.WriteLine($"ID: {torneo.ID} - Nombre:{torneo.Nombre}");
                    }
                    Console.WriteLine("Ingrese el nombre a cambiar: ");
                    string buscar = Console.ReadLine() ?? "";
                    var coincidencias = CrearTorneo.torneos.FirstOrDefault(n => n.Nombre == buscar);
                    if (coincidencias != null)
                    {
                        Console.WriteLine("Ingrese el nuevo nombre");
                        string Nuevo = Console.ReadLine() ?? "";
                        var name = CrearTorneo.torneos.FirstOrDefault(n => n.Nombre == Nuevo);
                        coincidencias.Nombre = Nuevo;
                        Console.WriteLine("Actualizado con exito");
                        foreach (var torneo in CrearTorneo.torneos)
                        {
                            Console.WriteLine($"nombre: {torneo.Nombre} - ID: {torneo.ID} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontro ningun torneo");
                        return;
                    }
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Opcion no encontrada");
                    break;
            }


        }
        
    }
}