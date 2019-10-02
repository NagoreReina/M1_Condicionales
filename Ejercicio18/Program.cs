using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            //18. Con if else if: Mostrar en pantalla un menú con varias opciones. 
            //Dependiendo de lo que el usuario elija, mostrar en pantalla la selección. 
            //Hacerlo tanto con if else como con switch.

            Console.WriteLine("Elige una opción de las siguientes:");
            Console.WriteLine("(Para indicar la opción, introduce el numero de esta)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Patata");
            Console.WriteLine("2. Boniato");
            Console.WriteLine("2. Melody");
            Console.WriteLine("2. Vitelotte");
            Console.WriteLine("------------------------------------");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            //Opción con if/else
            if (option == 1)
            {
                Console.WriteLine("Has elegido Patata");
            }
            else if (option == 2)
            {
                Console.WriteLine("Has elegido Boniato");
            }
            else if (option == 3)
            {
                Console.WriteLine("Has elegido Melody");
            }
            else if (option == 4)
            {
                Console.WriteLine("Has elegido Vitelotte");
            }

            //Opción con switch
            switch (option)
            {
                case 1:
                    Console.WriteLine("Has elegido Patata");
                    break;
                case 2:
                    Console.WriteLine("Has elegido Boniato");
                    break;
                case 3:
                    Console.WriteLine("Has elegido Melody");
                    break;
                case 4:
                    Console.WriteLine("Has elegido Vitelotte");
                    break;

            }


        }
    }
}
