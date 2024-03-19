using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            int baseRectangle, heightRectangle;

            Console.WriteLine("Enter the base of the rectangle:");
            baseRectangle = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the rectangle:");
            heightRectangle = int.Parse(Console.ReadLine());

            int areaRectangle = baseRectangle * heightRectangle;
            int perimeterRectangle = 2 * (baseRectangle + heightRectangle);

            Console.WriteLine("The area of the rectangle is: " + areaRectangle);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeterRectangle);
        }
    }
}
