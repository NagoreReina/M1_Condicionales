using System;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            //23. Escribe un programa que dice si los dígitos de un número de tres cifras son todos impares, 
            //todos pares o son mezclados. Tu programa debe pedir un número al usuario, y mostrar el número, 
            //seguido del mensaje "Todas las cifras son pares", "Todas las cifras son impares" o 
            //"El número tiene cifras pares e impares".

            Console.WriteLine("Escribe tu valor de 3 digitos");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num / 100;
            int num2 = num / 10;
            num2 = num2 % 10;
            int num3 = num % 10;
            if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
            {
                Console.WriteLine($"{num}, Todas las cifras son pares");
            }
            else if (num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 != 0)
            {
                Console.WriteLine($"{num}, Todas las cifras son impares");
            }
            else
            {
                Console.WriteLine($"{num}, El número tiene cifras pares e impares");
            }
            
        }
    }
}
