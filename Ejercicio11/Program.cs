using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //11. Escribe un programa el cual analizará si la contraseña introducida es correcta o no. 
            //Para que la contraseña sea correcta deberá cumplir estas directivas:
            //- Debe tener 8 caracteres como mínimo.

            Console.WriteLine("Introduce la nueva contraseña");
            string password = Console.ReadLine();
            if(password.Length >= 8)
            {
                Console.WriteLine("Contraseña valida");
            }
            else
            {
                Console.WriteLine("Contraseña demasiado corta, debe tener al menos 8 caracteres");
            }
        }
    }
}
