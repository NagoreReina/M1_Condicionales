using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida al usuario tres números y 
            //que diga si uno de ellos es 20 menos (exactamente) que uno de los otros.

            Console.WriteLine("Escribe el primer valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el tercer valor");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (((num1 + 20) - num2) == 0 || ((num2 + 20) - num1) == 0)
            {
                Console.WriteLine($"{num1} se distancia 20 de {num2}");
            }
            else if (((num2 + 20) - num3) == 0 || ((num3 + 20) - num2) == 0)
            {
                Console.WriteLine($"{num2} se distancia 20 de {num3}");
            }
            else if (((num3 + 20) - num1) == 0 || ((num1 + 20) - num3) == 0)
            {
                Console.WriteLine($"{num1} se distancia 20 de {num3}");
            }
            else
            {
                Console.WriteLine("ninguno cumple las condiciones");
            }
        }
    }
}
