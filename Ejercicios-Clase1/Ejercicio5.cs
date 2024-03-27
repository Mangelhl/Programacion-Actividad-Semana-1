using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Ejercicio5
    {
        internal static void RealizarEjercicio()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Enter the first number:");
                int num1;
                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                Console.WriteLine("Enter the second number: ");
                int num2;
                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                Console.WriteLine("Enter the symbol of the operation to be performed (+,-,*,/,%): ");
                char operation;
                if (!char.TryParse(Console.ReadLine(), out operation))
                {
                    Console.WriteLine("Invalid input. Please enter a valid operation symbol.");
                    continue;
                }

                int result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Error.");
                        break;

                    case '%':
                        if (num2 != 0)
                            result = num1 % num2;
                        else
                            Console.WriteLine("Error.");
                        break;

                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                Console.WriteLine("The result of the operation is: " + result);

                Console.WriteLine("Do you want to perform another operation? (Yes/No)");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "yes" && respuesta.ToLower() != "y")
                {
                    continuar = false;
                }
            }

            Console.WriteLine("Calculator terminated.");
        }
    }
}
