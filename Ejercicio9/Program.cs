using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Escribe un programa el que dada una frase sacará su carácter central. Nota:
            //- Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
            //- Si es impar deberá sacar su único carácter central.

            Console.WriteLine("Introduce una frase");
            string frase = Console.ReadLine();
            if(frase.Length % 2 == 0)//par
            {
                frase = frase.Substring((frase.Length -1) / 2, 2);
                Console.WriteLine(frase);
            }
            else //impar
            {
                frase = frase.Substring(frase.Length / 2, 1);
                Console.WriteLine(frase);
            }
        }
    }
}
