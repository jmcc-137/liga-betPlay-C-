using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LIGA.Models;
using LIGA.funciones_Equipo;

namespace LIGA.funciones_Equipo
{
    public class RegistrarCMedico
    {
        List<Med> Medicos { set; get; } = new List<Med>();
        public void ReMed()
        {
            if (RegistrarEquipo.equipo.Count == 0)
            {
                Console.WriteLine("No hay equipos disponibles");
                return;
            }

            Console.WriteLine("Registrar Cuerpo Medico");

            Console.WriteLine("ID");
            var id = Console.ReadLine() ?? "";
            int numero;
            if (!int.TryParse(id, out numero))
            {
                Console.WriteLine("ID Invalido(Solo numeros): ");
                return;
            }
            Console.WriteLine("Nombre:");
            string? nombre = Console.ReadLine();
            Console.WriteLine("Puesto(EJ: Doctor, Enfermero ... etc)");
            string? puesto = Console.ReadLine();
            Console.WriteLine("Origen: ");
            string? origen = Console.ReadLine();
            Console.WriteLine("Email: ");
            string? email = Console.ReadLine();

            Console.WriteLine("Seleccione el numero del equipo al que pertenece: ");
            for (int i = 0; i < RegistrarEquipo.equipo.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Nombre: {RegistrarEquipo.equipo[i].Name} - Pais: {RegistrarEquipo.equipo[i].Country}");
            }

            Console.WriteLine("Opcion: ");
            var opcion = Console.ReadLine();
            int indiceSeleccionado;

            if (!int.TryParse(opcion, out indiceSeleccionado) || indiceSeleccionado < 1 || indiceSeleccionado > RegistrarEquipo.equipo.Count)
            {
                Console.WriteLine("Seleccion invalida");
                return;
            }
            Team EquipoSeleccionado = RegistrarEquipo.equipo[indiceSeleccionado - 1];


            Med medico = new Med(numero, nombre, puesto, origen, email, EquipoSeleccionado);

            EquipoSeleccionado.Medicos.Add(medico);

            Medicos.Add(medico);

            Console.WriteLine("Medico agragado con exito");
            foreach (var item in EquipoSeleccionado.Medicos)
            {
                Console.WriteLine(item.ToString());
            }


        }

    }
}