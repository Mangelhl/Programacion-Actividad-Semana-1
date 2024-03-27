using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Ejercicio1.RealizarEjercicio();
            Ejercicio2.RealizarEjercicio();
            Ejercicio3.RealizarEjercicio();
            Ejercicio4.RealizarEjercicio();
            Ejercicio5.RealizarEjercicio();
            Ejercicio6.RealizarEjercicio();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Select the figure you want to operate: ");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Triangle");

                int option = int.Parse(Console.ReadLine());

                switch (option) 
                {
                    case 1:
                        Console.WriteLine("Enter the base of the rectangle:");
                        double baseRectangle = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the rectangle:");
                        double heightRectangle = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(baseRectangle, heightRectangle);
                        Console.WriteLine("The area of the rectangle is: " + rectangle.CalculateArea());
                        break;

                    case 2:
                        Console.WriteLine("Enter the radius of the circle:");
                        double radio = double.Parse(Console.ReadLine());

                        Circle circle = new Circle(radio);
                        Console.WriteLine("The area of the circle is " + circle.CalculateArea());
                        break;

                    case 3:
                        Console.WriteLine("Enter the base of the triangle:");
                        double baseTriangle = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the triangle:");
                        double heightTriangle = double.Parse(Console.ReadLine());

                        Triangle triangle = new Triangle(baseTriangle, heightTriangle);
                        Console.WriteLine("The area of the triangle is: " + triangle.CalculateArea());
                        break;

                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }

                Console.WriteLine("¿Do you want to select another figure? (Y/N)");
                string answer = Console.ReadLine().ToLower();
                if (answer != "s")
                    continuar = false;
            }
        }     

     }
}
