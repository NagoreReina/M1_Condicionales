using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida al usuario 3 números. 
            //Si el resultado de la suma de los dos primeros es igual al tercer número, 
            //mostrarlo en pantalla, sino mostrar que el tercero no es la suma de los dos anteriores.

            Console.WriteLine("Escribe el primer valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el tercer valor");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if ((num1 + num2) == num3)
            {
                Console.WriteLine("La suma de los 2 primeros numeros, es igual a " + num3);
            }
            else
            {
                Console.WriteLine($"El tercer valor no es la suma de los dos anteriores {num1} + {num2} = {num1+num2} no {num3}");
            }
        }
    }
}
