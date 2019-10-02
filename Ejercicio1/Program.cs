using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida dos números y que muestre la suma, 
            //la resta, la multiplicación, la media, el más grande y el más pequeño.

            Console.WriteLine("Escribe el primer valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double maxNum, minNum;
            if (num1 > num2)
            {
                maxNum = num1;
                minNum = num2;
            }
            else 
            {
                maxNum = num2;
                minNum = num1;
            }
            Console.WriteLine($"La suma de los dos numeros es {num1 + num2}");
            Console.WriteLine($"La resta de los dos numeros es {num1 - num2}");
            Console.WriteLine($"La multiplicacion de los dos numeros es {num1 * num2}");
            Console.WriteLine($"La media de los dos numeros es {(num1 + num2)/2}");
            Console.WriteLine($"el numero mas grande es {maxNum}");
            Console.WriteLine($"el numero mas pequeño es {minNum}");


        }
    }
}
