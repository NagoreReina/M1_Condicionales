using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que pida dos valores al usuario y 
            Si los dos valores son iguales muestre 0
            Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            Si no que muestre el más grande de los dos
            */

            Console.WriteLine("Escribe el primer valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (num1 == num2)
            {
                Console.WriteLine(0);
            }
            else if (num1 % 6 == num2 % 6)
            {
                if (num1 < num2)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
                
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
            }
        }
    }
}
