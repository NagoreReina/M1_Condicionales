using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //13. A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7".
            //Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor.

            Console.WriteLine("Escribe el un valor");
            int num = Convert.ToInt32(Console.ReadLine());
            num = Math.Abs(num);
            Console.WriteLine($"El valor absoluto de tu numero es {num}");
        }
    }
}
