using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //17. Un año es bisiesto si se puede dividir por 4.
            //Pero un año que se pueda dividir por 100 NO es bisiesto a no ser que se pueda dividir por 400.
            //A partir de un año, mostrar en pantalla si es bisiesto o no.

            Console.WriteLine("Introduce el año a comprobar");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        //SI
                        Console.WriteLine("Es bisiesto");
                    }
                    else
                    {
                        //NO
                        Console.WriteLine("no es bisiesto");
                    }

                }
                else
                {
                    //SI
                    Console.WriteLine("Es bisiesto");
                }
            }
            else
            {
                //NO
                Console.WriteLine("no es bisiesto");
            }
        }
    }
}
