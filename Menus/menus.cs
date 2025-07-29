using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LIGA.Models;
using LIGA.funciones_Equipo;
using LIGA.funciones_extras;
namespace LIGA.Menus
{
    public class Menu
    {

    private List<Torneo> torneos = new List<Torneo>();
    private List<Team> equipos = new List<Team>();
        public void MainMenu()
        {
             while (true)
             {
                LetraPorLetra efecto = new LetraPorLetra();
            Console.Clear();
            efecto.efectoEcribir("0. Create Torneo");
            efecto.efectoEcribir("1. Registro Equipos");
            efecto.efectoEcribir("2. Registro jugadores");
            efecto.efectoEcribir("3. Transferencias (Compra,Prestamo)");
            efecto.efectoEcribir("4. Estadisticas");
            efecto.efectoEcribir("5. Salir");

            int opcion = int.Parse(Console.ReadLine() ?? "");
            switch (opcion)
            {
                case 0:
                    MenuCero();
                    break;

                case 1:
                        MenuUno();
                    break;
                case 2:
                        MenuDos();
                    break;
                case 3:
                        MenuTres();
                    break;
                case 4:
                        MenuCuatro();
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
            LetraPorLetra efecto = new LetraPorLetra();
            efecto.efectoEcribir("1 Add Torneo");
            efecto.efectoEcribir("2 Buscar Torneo");
            efecto.efectoEcribir("3 Eliminar Torneo");
            efecto.efectoEcribir("4 Actualizar Torneo");
            efecto.efectoEcribir("5 Back Main Mneu");

            var opcion = int.Parse(Console.ReadLine()?? "");

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
            while (true) {
                LetraPorLetra efecto = new LetraPorLetra();
                efecto.efectoEcribir("1 Registrar Equipo");
                efecto.efectoEcribir("2 Registrar Cuerpo Tecnico");
                efecto.efectoEcribir("3 Registrar Cuerpo Medico");
                efecto.efectoEcribir("4 Inscripcion Torneo");
                efecto.efectoEcribir("5 Notificacion de Transferencias");
                efecto.efectoEcribir("6 Salir De Torneo");
                efecto.efectoEcribir("7 Salir Main Menu");

                var opcion = int.Parse(Console.ReadLine() ?? "");

                switch (opcion)
                {
                    case 1:
                        RegistrarEquipo RE = new RegistrarEquipo();
                        RE.Registrar();
                        break;
                    case 2:
                        RegistrarCTecnico RT = new RegistrarCTecnico();
                        RT.ReTec();
                        break;
                    case 3:
                        RegistrarCMedico RM = new RegistrarCMedico();
                        RM.ReMed();
                        break;
                    case 4:
                        IncripcionTorneo IT = new IncripcionTorneo();
                        IT.InsTor();
                        break;
                    case 5:
                        break;
                    case 6:
                        SalirTorneo ST = new SalirTorneo();
                        ST.SalirDeTorneo();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        public void MenuDos()
        {
            while (true)
            {
                Console.Clear();
                LetraPorLetra efecto = new LetraPorLetra();
                efecto.efectoEcribir("1 Registrar Jugador");
                efecto.efectoEcribir("2 Buscar Jugador");
                efecto.efectoEcribir("3 Editar Jugador");
                efecto.efectoEcribir("4 Eliminar Jugador");
                efecto.efectoEcribir("5 Salir Main Menu");
                var opcion = int.Parse(Console.ReadLine() ?? "");

                switch (opcion)
                {
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
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        public void MenuTres()
        {
            Console.Clear();
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