using System;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            //El usuario tiene dos hijos. Pregúntale la edad del mayor y los años de diferencia entre el mayor 
            //y el menor. Muestra en pantalla si el menor es mayor de edad o no.
            Console.WriteLine("Escribe la edad de tu hijo mayor");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe cuantos años se llevan");
            int ageDiference = Convert.ToInt32(Console.ReadLine());

            if (age - ageDiference > 17)
            {
                Console.WriteLine("Tu hijo menor es mayor de edad");
            }
            else
            {
                Console.WriteLine("Tu hijo menor NO es mayor de edad");
            }

        }
    }
}
