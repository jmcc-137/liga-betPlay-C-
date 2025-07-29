using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIGA.funciones_extras
{
    public class cambio_de_color_de_la_consola
    {
        public void IniciarCambio()
        {
            Thread colorThread = new Thread(CambiarColorTexto);
            colorThread.IsBackground = true;
            colorThread.Start(); // 🔥 Arranca el hilo de color
        }

        public void CambiarColorTexto()
        {
            ConsoleColor[] colores = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Random rnd = new Random();

            while (true)
            {
                Console.ForegroundColor = colores[rnd.Next(colores.Length)];
                Thread.Sleep(300); // Cambia color cada 300ms
            }
        }
    }
}