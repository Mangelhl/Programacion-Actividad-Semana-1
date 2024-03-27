using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Ejercicio2
    {
        internal static void RealizarEjercicio()
        {
            int baseTriangle, heightTriangle;

            Console.WriteLine("Enter the base of the Triangle:");
            baseTriangle = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the Triangle:");
            heightTriangle = int.Parse(Console.ReadLine());

            double areaTriangle = 0.5 * baseTriangle * heightTriangle;

            Console.WriteLine("The area of the triangle is: " + areaTriangle);
        }
    }
}
