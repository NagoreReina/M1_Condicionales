using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //16. Escribe un programa para una empresa de alquiler de coches. 
            //Tendremos que preguntar al usuario la edad. Si el usuario es menor de 18, 
            //no podrá alquilar un vehículo y se lo diremos pantalla. 
            //En caso de ser mayor de edad, le preguntamos si tiene carnet de conducir. 
            //Si la respuesta es negativa, no podrá alquilar un coche y se lo advertiremos por pantalla. 
            //Si es  mayor de edad le pediremos tanto nombre como apellido , 
            //ciudad de recogida del vehículo y número de días que quiere alquilar el coche 
            //(el alquiler del coche por día tiene un coste de 25 euros y en caso que lo alquile una semana, 
            //el coste será de 150 euros). Imprimir por pantalla los datos del cliente que vaya a alquilar el coche 
            //y el coste total del alquiler.

            Console.WriteLine("¿Cual es tu edad?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Lo sentimos, pero no puedes alquilar un coche por tu edad");
            }
            else
            {
                Console.WriteLine("¿Tienes carnet de conducir?");
                string carnet = Console.ReadLine();
                carnet = carnet.ToLower();
                if (carnet.Contains("no"))
                {
                    Console.WriteLine("Lo sentimos, pero no puedes alquilar un coche por no tener carnet de conducir");
                }
                else
                {
                    Console.WriteLine("Bien, ahora vamos a recoger unos datos, ¿Nombre?");
                    string name = Console.ReadLine();
                    Console.WriteLine("¿Apellido?");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("¿Donde vas a recoger el vehiculo?");
                    string city = Console.ReadLine();
                    Console.WriteLine("¿Cuántos dias lo quieres alquilar?");
                    int days = Convert.ToInt32(Console.ReadLine());
                    int prize = 25;

                    if (days == 7)
                    {
                        prize = 150;
                    }
                    else
                    {
                        prize *= days;
                    }
                    //Mostrar los datos
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Datos del alquiler:");
                    Console.WriteLine($"Solicitante: {name} {lastName}");
                    Console.WriteLine($"Edad del solicitante: {age}");
                    Console.WriteLine($"carnet: {carnet}");
                    Console.WriteLine($"Ciudad de recogida: {city}");
                    Console.WriteLine($"Dias de alquiler: {days}");
                    Console.WriteLine($"Precio total: {prize}");
                    Console.WriteLine("--------------------------------");

                }
            }
        }
    }
}
