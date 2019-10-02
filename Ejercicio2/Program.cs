using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pide por teclado la edad del usuario. 
            //Si la edad es igual o inferior a 8 mostramos mensaje 
            //"Pasa al tobogán", si no mostramos "Eres demasiado mayor para usar el tobogán".

            Console.WriteLine("¿Cual es tu edad?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 8)
            {
                Console.WriteLine("Pasa al tobogán");
            }
            else
            {
                Console.WriteLine("Eres demasiado mayor para usar el tobogán");
            }
        }
    }
}
