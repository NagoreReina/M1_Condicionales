using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            //19. Mostrar el mayor de tres valores
            Console.WriteLine("Escribe el primer valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el tercer valor");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"el mayor es {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"el mayor es {num2}");
            }
            else
            {
                Console.WriteLine($"el mayor es {num3}");
            }
        }
    }
}
