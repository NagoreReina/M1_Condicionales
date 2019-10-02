using System;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            //27. Escribe un programa que pida dos números al usuario. 
            //Después muestra un mensaje que dice cómo se relacionan entre los dos. 
            //Por ejemplo si escribe 5 y 7 , muestra "5 es menor que 7".

            Console.WriteLine("Escribe el primer valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} es mayor que {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} es mayor que {num1}");
            }
            else
            {
                Console.WriteLine($"{num2} es igual a {num1}");
            }

        }
    }
}
