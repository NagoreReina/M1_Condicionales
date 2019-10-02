using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            //14. Decir el número de helados que queremos comprar. 
            //Cada helado vale 2 euros. Si compramos más de 10 helados, 
            //nos regalan uno gratis. Mostrar en pantalla el número de helados
            //que nos dan y cuánto hemos pagado por ellos.

            Console.WriteLine("¿Cuantos helados quieres comprar?");
            int num = Convert.ToInt32(Console.ReadLine());
            int prize = 2;
            if(num > 10)
            {
                prize *= num;
                num += 1;
            }
            else
            {
                prize *= num;
            }
            Console.WriteLine($"Has obtenido {num} helados y te han costado {prize}");
        }
    }
}
