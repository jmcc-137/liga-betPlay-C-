using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using LIGA.Models;

namespace LIGA.funciones_Equipo
{
    public class SalirTorneo
    {

        public void SalirDeTorneo()
        {
            if (CrearTorneo.torneos.Count == 0)
            {
                Console.WriteLine("No hay torneos registrados.");
                return;
            }

            Console.WriteLine("Torneos disponibles:");
            for (int i = 0; i < CrearTorneo.torneos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {CrearTorneo.torneos[i].Nombre}");
            }

            Console.Write("Seleccione el número del torneo: ");
            if (!int.TryParse(Console.ReadLine(), out int torneoIndex) || torneoIndex < 1 || torneoIndex > CrearTorneo.torneos.Count)
            {
                Console.WriteLine("Selección inválida.");
                return;
            }

            Torneo torneoSeleccionado = CrearTorneo.torneos[torneoIndex - 1];

            if (torneoSeleccionado.equiposParticipantes.Count == 0)
            {
                Console.WriteLine("Este torneo no tiene equipos inscritos.");
                return;
            }

            Console.WriteLine("Equipos inscritos en el torneo:");
            for (int i = 0; i < torneoSeleccionado.equiposParticipantes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {torneoSeleccionado.equiposParticipantes[i].Name}");
            }

            Console.Write("Seleccione el número del equipo que desea sacar del torneo: ");
            if (!int.TryParse(Console.ReadLine(), out int equipoIndex) || equipoIndex < 1 || equipoIndex > torneoSeleccionado.equiposParticipantes.Count)
            {
                Console.WriteLine("Selección inválida.");
                return;
            }

            Team equipoARemover = torneoSeleccionado.equiposParticipantes[equipoIndex - 1];

            torneoSeleccionado.equiposParticipantes.Remove(equipoARemover);
            Console.WriteLine($"Equipo '{equipoARemover.Name}' ha sido removido del torneo '{torneoSeleccionado.Nombre}'.");
        }
    }
}
