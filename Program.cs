
using LIGA.funciones_Equipo;
using LIGA.Menus;
using LIGA.Models;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Player player = new Player();
        Menu menu = new Menu();
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
        // team.Players.Add(player);

        // Console.WriteLine(player.ToString());
        // Console.WriteLine(team.ToString());
        menu.MainMenu();
        
    }        
}
