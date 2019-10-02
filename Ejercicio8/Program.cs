using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Resultado de carrera. Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó. Después:
                - Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
                - Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro",
                si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
                - Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro",
                si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata",
                si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
                - Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje 
                "Se acabó la carrera". Hazlo usando un if/else y usando switch
             */

            Console.WriteLine("¿En que puesto has quedado?");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Opcion 1
            if (num1 == 1)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Lo importante es participar");
            }
            //Opcion 2
            if (num1 == 1)
            {
                Console.WriteLine("Medalla de oro");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Medalla de plata");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("Medalla de bronce");
            }
            else
            {
                Console.WriteLine("Lo importante es participar");
            }
            //Opcion 3
            switch (num1)
            {
                case 1:
                    Console.WriteLine("Medalla de oro");
                    break;
                case 2:
                    Console.WriteLine("Medalla de plata");
                    break;
                case 3:
                    Console.WriteLine("Medalla de bronce");
                    break;
                default:
                    Console.WriteLine("Lo importante es participar");
                    break;
            }
            //Opcion 4
            if (num1 < 4)
            {
                Console.WriteLine("Sube al podium");
            }
            else
            {
                Console.WriteLine("Se acabó la carrera");
            }
            //opcion 4.1
            switch (num1)
            {
                case 1:
                    Console.WriteLine("Sube al podium");
                    break;
                case 2:
                    Console.WriteLine("Sube al podium");
                    break;
                case 3:
                    Console.WriteLine("Sube al podium");
                    break;
                default:
                    Console.WriteLine("Se acabó la carrera");
                    break;
            }
        }
    }
}
