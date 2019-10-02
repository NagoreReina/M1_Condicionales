using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //21.Un programa que te pregunta la temperatura que hace donde estás y
            //te sugiere qué hacer dependiendo de ella. Las recomendaciones son:
            //- Si en hace más de 40 grados, vete a otro sitio
            //- Entre 30 y 40 grados, enciende el aire acondicionado
            //- Entre 30 y 20 grados, no hagas nada
            //- Entre 10 y 20 grados, enciende la calefacción
            //- Si hace menos de 10 grados, vete a otro sitio

            Console.WriteLine("Escribe la temperatura");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (temperature > 40 || temperature < 10)
            {
                Console.WriteLine("Vete a otro sitio");                
            }
            else if (temperature > 30 && temperature <= 40)
            {
                Console.WriteLine("enciende el aire acondicionado");
            }
            else if (temperature > 20 && temperature <= 30)
            {
                Console.WriteLine("no hagas nada");
            }
            else if (temperature >= 10 && temperature <= 20)
            {
                Console.WriteLine("enciende la calefacción");
            }


        }
    }
}
