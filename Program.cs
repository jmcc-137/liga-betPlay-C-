
using LIGA.funciones_Equipo;
using LIGA.Menus;
using LIGA.Models;
using LIGA.funciones_extras;
internal class Program
{
    public static void Main(string[] args)
    {

        cambio_de_color_de_la_consola cambiar = new cambio_de_color_de_la_consola();
        cambiar.IniciarCambio();


        Menu menu = new Menu();
        menu.MainMenu();
        Player player = new Player();
       
        
        // player.Id = 1;
        // player.Name = "juan";
        // player.Origen = "USA";
        // player.Email = "jm@gmail.com";
        // player.Dorsal = 10;
        // player.Position = "def";

        // Team team = new Team();
        // team.Id = 1;
        // team.Name = "JM";
        // team.City = "San jose";
        // team.Players.Add(player);Program.cs

        // Console.WriteLine(player.ToString());
        // Console.WriteLine(team.ToString());


    }        
}
