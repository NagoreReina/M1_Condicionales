using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //15. Tenemos dos números, un numerador y un denominador. 
            //Si el denominador no es cero, mostramos el resultado de dividir el numerador por el denominador. 
            //Si el denominador es cero, mostramos el mensaje "No se puede dividir por cero".
            Console.WriteLine("Escribe el numerador");
            double numerador = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el denominador");
            double denominador = Convert.ToDouble(Console.ReadLine());

            if (denominador == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            else
            {
                Console.WriteLine($"El resultado de la division es {numerador/denominador}");
            }

        }
    }
}
