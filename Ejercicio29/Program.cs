using System;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            //29.Bob es un adolescente vago, en una conversación sus contestaciones son muy limitadas:
            //  • Bob responde: “¡Claro!”  si le haces una pregunta.
            //  • Bob responde “¡Eh!, tranquilízate.” si le gritas.
            //  • Bob responde “¡Eh, tranquilízate! Yo sé lo que hago.” Si le haces una pregunta gritándole.
            //  • Bob responde “Vale con que esas tenemos...” Si no le dices nada.
            //  • Bob responde “Sin más.” a cualquier otra cosa.

            inicio:
            Console.WriteLine("Hablale a Bob");
            string frase = Console.ReadLine();

            if (frase.Contains("¡¿") && frase.Contains("?!"))
            {
                Console.WriteLine("Bob dice: ¡Eh, tranquilízate! Yo sé lo que hago.");
            }
            else if (frase.Contains("¿") && frase.Contains("?"))
            {
                Console.WriteLine("Bob dice: ¡Claro!");
            }
            else if (frase.Contains("¡") && frase.Contains("!"))
            {
                Console.WriteLine("Bob dice: ¡Eh!, tranquilízate.");
            }
            else if (frase == "")
            {
                Console.WriteLine("Bob dice: Vale con que esas tenemos...");
            }
            else
            {
                Console.WriteLine("Bob dice: Sin más.");
            }
            goto inicio;

        }
    }
}
