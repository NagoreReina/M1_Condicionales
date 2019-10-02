using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida dos números enteros entre 25 y 75
            //y que diga si hay un dígito en común entre los dos números.
            Console.WriteLine("Escribe el primer valor entre 25 y 75");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor entre 25 y 75");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num1Part1 = num1 / 10;
            int num1Part2 = num1 % 10;
            int num2Part1 = num2 / 10;
            int num2Part2 = num2 % 10;

            if (num1Part1 == num2Part1 || num1Part1 == num2Part2 || num1Part2 == num2Part1 || num1Part2 == num2Part2)
            {
                Console.WriteLine("Hay un digito en común");
            }
            else
            {
                Console.WriteLine("No hay ningun digito en comun");
            }
        }
    }
}
