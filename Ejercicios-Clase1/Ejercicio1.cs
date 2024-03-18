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
            double baseRectangle, heightRectangle;

            Console.WriteLine("Ingrese la base del rectángulo:");
            baseRectangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectángulo:");
            heightRectangle = Convert.ToDouble(Console.ReadLine());

            double areaRectangle = baseRectangle * heightRectangle;
            double perimeterRectangle = 2 * (baseRectangle + heightRectangle);

            Console.WriteLine("El área del rectángulo es: " + areaRectangle);
            Console.WriteLine("El perímetro del rectángulo es: " + perimeterRectangle);
        }
    }
}
