using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que evalúe si un string contiene la letra ‘r’ (pista: usar función de string).
            Console.WriteLine("Introduce una frase");
            string frase = Console.ReadLine();
            if (frase.Contains("r"))
            {
                Console.WriteLine("contiene la r");
            }
            else
            {
                Console.WriteLine("no contiene la r");
            }
        }
    }
}
