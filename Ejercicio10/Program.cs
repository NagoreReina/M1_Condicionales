using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.Comprobar un string que tenga el valor del día de la semana (lunes, martes, ...). 
            //Mostrar en pantalla el día que dice que es si es entre lunes y viernes (Por ejemplo "Hoy es lunes")
            //y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.

            Console.WriteLine("Introduce el dia de la semana");
            string frase = Console.ReadLine();
            frase = frase.ToLower(); //pasar a minusculas por si el usuario introduce mayusculas

            //Con if else
            if (frase.Contains("lunes"))
            {
                Console.WriteLine("lunes");
            }
            else if (frase.Contains("martes"))
            {
                Console.WriteLine("martes");
            }
            else if (frase.Contains("miercoles"))
            {
                Console.WriteLine("miercoles");
            }
            else if (frase.Contains("jueves"))
            {
                Console.WriteLine("jueves");
            }
            else if (frase.Contains("viernes"))
            {
                Console.WriteLine("viernes");
            }
            else if (frase.Contains("sabado"))
            {
                Console.WriteLine("Hoy es fin de semana");
            }
            else if (frase.Contains("domingo"))
            {
                Console.WriteLine("Hoy es fin de semana");
            }
            else
            {
                Console.WriteLine("No has introducido un dia");
            }
            //con switch
            switch (frase)
            {
                case "lunes":
                    Console.WriteLine("lunes");
                    break;
                case "martes":
                    Console.WriteLine("martes");
                    break;
                case "miercoles":
                    Console.WriteLine("miercoles");
                    break;
                case "jueves":
                    Console.WriteLine("jueves");
                    break;
                case "viernes":
                    Console.WriteLine("viernes");
                    break;
                case "sabado":
                    Console.WriteLine("Hoy es fin de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Hoy es fin de semana");
                    break;
                default:
                    Console.WriteLine("No has introducido un dia");
                    break;


            }
        }
    }
}
