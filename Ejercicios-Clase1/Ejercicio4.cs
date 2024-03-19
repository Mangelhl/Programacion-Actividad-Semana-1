using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clase1
{
    internal class Ejercicio4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the symbol of the operation to be performed (+,-,*,/,%): ");
            char operation = char.Parse(Console.ReadLine());

            int result = 0;

            switch(operation)
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
                        Console.WriteLine("Error");
                    break;

                case '%':
                    if (num2 != 0)
                        result = num1 % num2;
                    else
                        Console.WriteLine("Error");
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            Console.WriteLine("The result of the operation is: " + result);
        }
    }
}
