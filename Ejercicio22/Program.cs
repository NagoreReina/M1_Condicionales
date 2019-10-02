using System;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            //22. En una clase tienes tres exámenes, con un valor de 5 puntos máximo en cada uno. 
            //La nota final es la mejor nota de los dos primeros exámenes más la nota del tercer examen. 
            //Crea un programa que con tres notas calcula el resultado de nota final con los siguientes rangos:
            //    10 es matrícula
            //    9 y hasta 10 es sobresaliente
            //    7 y hasta 9 es notable
            //    6 y hasta 7 es bien
            //    5 y hasta 6 es suficiente
            //    0 hasta 5 es suspenso

            Console.WriteLine("Escribe la nota del primer examen");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la nota del segundo examen");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la nota del tercer examen");
            double num3 = Convert.ToDouble(Console.ReadLine());
            if (num1 < num2)
            {
                num1 = num2;
            }
            double notaFinal = num1 + num3;
            
            if (notaFinal == 10)
            {
                Console.WriteLine("Matricula");
            }
            else if (notaFinal >= 9)
            {
                Console.WriteLine($"Sobresaliente, tienes un {notaFinal.ToString("0.00")}");
            }
            else if (notaFinal >= 7)
            {
                Console.WriteLine($"Notalbe, tienes un {notaFinal.ToString("0.00")}");
            }
            else if (notaFinal >= 6)
            {
                Console.WriteLine($"Bien, tienes un {notaFinal.ToString("0.00")}");
            }
            else if (notaFinal >= 5)
            {
                Console.WriteLine($"suficiente, tienes un {notaFinal.ToString("0.00")}");
            }
            else 
            {
                Console.WriteLine($"Suspenso, tienes un {notaFinal.ToString("0.00")}");
            }

        }
    }
}
