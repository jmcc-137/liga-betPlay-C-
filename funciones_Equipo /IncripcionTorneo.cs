using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIGA.Models;
using LIGA.funciones_Equipo;

namespace LIGA.funciones_Equipo 

{
    public class IncripcionTorneo
    {

        public void InsTor()
        {

            if (CrearTorneo.torneos.Count == 0 && RegistrarEquipo.equipo.Count == 0)
            {
                Console.WriteLine("No hay torneos credos y tampoco equipo");
                return;
            }
            Console.WriteLine("Torneos disponibles");
            foreach (var t in CrearTorneo.torneos)
            {
                Console.WriteLine($"ID: {t.ID} - Nombre:{t.Nombre}");
            }

            if (RegistrarEquipo.equipo.Count == 0)
            {
                Console.WriteLine("no hay equipos registrados");
                return;
            }

            Console.WriteLine("Ingrese ID del torneo donde desea inscribir el equipo");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int idSeleccionado))
            {
                var torneoSeleccionado = CrearTorneo.torneos.FirstOrDefault(t => t.ID == idSeleccionado);
                if (torneoSeleccionado == null)
                {
                    Console.WriteLine("Torneo no encontrado.");
                    return;
                }
                if (RegistrarEquipo.equipo.Count == 0)
                {
                    Console.WriteLine("no hay equipos desponibles para inscribir.");
                    return;
                }

                var equiposDisponibles = RegistrarEquipo.equipo
                    .Where(e => !torneoSeleccionado.equiposParticipantes.Any(eq => eq.ID == e.ID))
                    .ToList();

                if (equiposDisponibles.Count == 0)
                {
                    Console.WriteLine("No hay equipos disponibles para este torneo. Todos ya están inscritos.");
                    return;
                }

                Console.WriteLine("Equipos disponibles para inscripción:");
                foreach (var e in equiposDisponibles)
                {
                    Console.WriteLine(e.ToString());
                }

                Console.WriteLine("Ingrese el ID del equipo a inscribir:");
                string equipoInput = Console.ReadLine() ?? "";

                if (int.TryParse(equipoInput, out int idEquipo))
                {
                    var equipo = equiposDisponibles.FirstOrDefault(e => e.ID == idEquipo);
                    if (equipo != null)
                    {
                        torneoSeleccionado.equiposParticipantes.Add(equipo);
                        Console.WriteLine($"Equipo '{equipo.Name}' Inscrito correctamente al torneao '{torneoSeleccionado.Nombre}'");
                    }
                    else
                    {
                        Console.WriteLine("Equipo no encontrado.");
                    }
                }

            }
            else
            {
                Console.WriteLine("ID Invalivo.");
            }

        }
        
    }
}