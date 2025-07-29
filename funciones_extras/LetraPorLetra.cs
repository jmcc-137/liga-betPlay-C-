using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIGA.funciones_extras
{
    public class LetraPorLetra
    {
        public void efectoEcribir(string texto, int velocidad = 10)
        {
            foreach (char letra in texto)
            {
                Console.Write(letra);
                Thread.Sleep(velocidad);
            }
            Console.WriteLine();
        }
    }
}