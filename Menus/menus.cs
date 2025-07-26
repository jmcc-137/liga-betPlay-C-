using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LIGA.Models;
using LIGA.funciones;

namespace LIGA.Menus
{
    public class Menu
    {


        public void MainMenu()
        {
             while (true)
             {
            Console.Clear();
            Console.WriteLine("0. Create Torneo");
            Console.WriteLine("1. Registro Equipos");
            Console.WriteLine("2. Registro jugadores");
            Console.WriteLine("3. Transferencias (Compra,Prestamo)");
            Console.WriteLine("4. Estadisticas");
            Console.WriteLine("5. Salir");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 0:
                    MenuCero();
                    break;

                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("opcion invalida");
                    break;
                }
            }
        }
        public void MenuCero()
        {

             while (true)
             {

            Console.WriteLine("1 Add Torneo");
            Console.WriteLine("2 Buscar Torneo");
            Console.WriteLine("3 Eliminar Torneo");
            Console.WriteLine("4 Actualizar Torneo");
            Console.WriteLine("5 Back Main Mneu");

            var opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                        CrearTorneo CT = new CrearTorneo();
                        CT.Crear();
                    break;
                case 2:
                        SearhTorneo BT = new SearhTorneo();
                        BT.Buscar();
                    break;
                case 3:
                        DeleteTorneo DT = new DeleteTorneo();
                        DT.Elimiar();
                    break;
                case 4:
                        UpdateTorneo AT = new UpdateTorneo();
                        AT.Actualizar();
                    break;
                case 5:
                        return;
                default:
                    Console.WriteLine("opcion invalida");
                    break;
            }
         }
        }

        public void MenuUno()
        {
            Console.WriteLine("1.1 Registrar Equipo");
            Console.WriteLine("1.2 Registrar Cuerpo Tecnico");
            Console.WriteLine("1.3 Registrar Cuerpo Medico");
            Console.WriteLine("1.4 Inscripcion Torneo");
            Console.WriteLine("1.5 Notificacion de Transferencias");
            Console.WriteLine("1.6 Salir De Torneo");
            Console.WriteLine("1.7 Salir Main Menu");
        }
        public void MenuDos()
        {
            Console.WriteLine("2.1 Registrar Jugador");
            Console.WriteLine("2.2 Buscar Jugador");
            Console.WriteLine("2.3 Editar Jugador");
            Console.WriteLine("2.4 Eliminar Jugador");
            Console.WriteLine("2.5 Salir Main Menu");
        }
        public void MenuTres()
        {
            Console.WriteLine("3.1 Comprar Jugador");
            Console.WriteLine("3.2 Prestar Jugador");
            Console.WriteLine("3.2 Salir Main Menu");
        }

        public void MenuCuatro()
        {
            Console.WriteLine("4.1 Jugador Con Mas Asistencias a Torneo");
            Console.WriteLine("4.2 Equipos Con Mas Goles");
            Console.WriteLine("4.3 Jugadores Mas Caros Por Equipo");
            Console.WriteLine("4.4 Jugadores Menor Al Promedio De Edad Por Equipo");
            Console.WriteLine("4.5 Salir Main Menu");
        }

        public void SubMenu()
        {
            Console.Clear();
            Console.WriteLine("1. por ID");
            Console.WriteLine("2. por nombre");
            Console.WriteLine("3. salir");
            

        }
    }
}