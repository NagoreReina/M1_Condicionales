using System;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ejercicio

            //26. Crea un programa para ver si los comerciales reciben un extra. 
            //Si venden más de 500 euros, les damos un extra de el 5% de lo que han vendido. 
            //El usuario introduce su nombre y el precio de las ventas. Muestra en pantalla las su nombre, 
            //seguido de las ventas y en el caso de que las ventas superen 500 euros el 5% de las ventas como extra.
            #endregion

            Console.WriteLine("Introduce tu nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce tus ventas");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine($"Nombre: {name}");
            Console.WriteLine($"Ventas: {value}");
            if (value > 500)
            {
                double extra = (value/100) * 5;
                Console.WriteLine($"Extra: {extra.ToString("0.00")}");
            }
            Console.WriteLine("----------------");

        }
    }
}
