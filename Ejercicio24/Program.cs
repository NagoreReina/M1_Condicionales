using System;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            //24. Para convertir de grados centígrados a grados fahrenheit multiplicamos por 9, 
            //le dividimos 5 y a ese resultado le añadimos 32. Para convertir de fahrenheit a centígrados 
            //le restamos 32, multiplicamos por 5 y dividimos entre 9. Pide un valor y pregunta al usuario 
            //si quiere convertirlo a centígrados (si escribe C) o si quiere convertirlo a fahrenheit 
            //(si escribe F) y muestra el valor en pantalla.
            Console.WriteLine("Introduce el valor");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Quieres convertirlos a centrigrados o a fahrenheit?");
            Console.WriteLine("introduce una C si los quieres en centigrados y una F si los quieres en fahrenheit");
            string option = Console.ReadLine();
            option = option.ToLower();
            if (option.Contains("c"))
            {
                temperature = (temperature - 32) / 1.8;
                Console.WriteLine($"la temperatura introducida son {temperature.ToString("0.00")}ºC");
            }
            else if (option.Contains("f"))
            {
                temperature = (temperature * 1.8) + 32;
                Console.WriteLine($"la temperatura introducida son {temperature.ToString("0.00")}ºF");
            }
            else
            {
                Console.WriteLine("Eso no es una opción");
            }

        }
    }
}
