using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Ejercicio3
    {
        internal static void RealizarEjercicio()
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year %400 == 0))
            {
                Console.WriteLine("The year " + year + " it's a leap year");
            }

            else
            {
                Console.WriteLine("The year " + year + " it's not a leap year");
            }
        }
    }
}
