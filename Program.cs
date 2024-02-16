// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, new calculator!");

using System;

namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.WriteLine("Bienvenido a la calculadora en C#!");
            Console.WriteLine("-----------------------------------");

            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la operación (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

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
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
                default:
                    Console.WriteLine("Error: Operación no válida.");
                    break;
            }

            Console.WriteLine($"El resultado es: {result}");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Gracias por utilizar la calculadora.");
        }
    }
}
