using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    class Ejercicio6
    {
        internal static void RealizarEjercicio()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Select a geometric figure:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit");
            

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CalculateCircle();
                    break;

                case "2":
                    CalculateRectangle();
                    break;

                case "3":
                    CalculateTriangle();
                    break;

                case "4":
                    continuar = false;
                    Console.WriteLine("Program finished.");
                    break;

                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }

             Console.WriteLine("Do you wish to continue? (YES/NO) ");
             string answer = Console.ReadLine();
             if(answer.ToLower() != "YES" && answer.ToLower() != "YES")
             {
                continuar = false;
             }

            }

        }

    static void CalculateCircle()
    {
        Console.WriteLine("Enter the radius of the circle: ");
        double radius;
        if(!double.TryParse(Console.ReadLine(), out radius))
        {
            Console.WriteLine("Invalid Enter.");
            return;
        }

        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine("The area of the circle is: " + area);
        Console.WriteLine("The perimeter of the circle is: " + perimeter);
    }

    static void CalculateRectangle()
    {
        Console.WriteLine("Enter the base of the rectangle:");
        double baseRectangle;
        if (!double.TryParse(Console.ReadLine(), out baseRectangle))
        {
            Console.WriteLine("Invalid Enter.");
            return;
        }

        Console.WriteLine("Enter the height of the rectangle:");
        double heightRectangle;
        if (!double.TryParse(Console.ReadLine(), out heightRectangle))
        {
            Console.WriteLine("Invalid Enter.");
            return;
        }

        double area = baseRectangle * heightRectangle;
        double perimeter = 2 * (baseRectangle + heightRectangle);

        Console.WriteLine("The area of the rectangle is: " + area);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }

    static void CalculateTriangle()
    {
        Console.WriteLine("Enter the base of the triangle:");
        double baseTriangle;
        if (!double.TryParse(Console.ReadLine(), out baseTriangle))
        {
            Console.WriteLine("Invalid Enter.");
            return;
        }

        Console.WriteLine("Ingrese la altura del triángulo:");
        double heightTriangle;
        if (!double.TryParse(Console.ReadLine(), out heightTriangle))
        {
            Console.WriteLine("Invalid Enter.");
            return;
        }

        double area = 0.5 * baseTriangle * heightTriangle;

        Console.WriteLine("The area of the triangle is: " + area);
    }

    }

}
