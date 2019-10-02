using System;

namespace Ejercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            //28. Escribe un programa que pida un número y muestre ese número al cuadrado y al cubo 
            //(multiplicado por sí mismo dos y tres veces). Si el número es menor que 1, no calcules el cubo ni el 
            //cuadrado.

            Console.WriteLine("Escribe un valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            if (num1 >= 1)
            {
                Console.WriteLine($"Al cuadrado {num1 * num1} al cubo {num1 * num1 * num1}");
            }

        }
    }
}
