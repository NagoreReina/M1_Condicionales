using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //---- EJERCICIO 1 -------
            //Console.WriteLine("Escribe el primer valor");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Escribe el segundo valor");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales");
            //}

            //---- EJERCICIO 2 -------
            //Console.WriteLine("Escribe el un valor");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("es par");
            //}
            //else
            //{
            //    Console.WriteLine("es impar");
            //}

            //---- EJERCICIO 3 -------
            //Console.WriteLine("Escribe el un valor");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //switch (num1)
            //{
            //    case 1:
            //        Console.WriteLine("Lunes");
            //        break;
            //    case 2:
            //        Console.WriteLine("Martes");
            //        break;
            //    case 3:
            //        Console.WriteLine("Miercoles");
            //        break;
            //    case 4:
            //        Console.WriteLine("Jueves");
            //        break;
            //    case 5:
            //        Console.WriteLine("Viernes");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sabado");
            //        break;
            //    case 7:
            //        Console.WriteLine("Domigno");
            //        break;
            //    default:
            //        Console.WriteLine("Ninguno");
            //        break;
            //}

            //---- EJERCICIO 4 -------
            Console.WriteLine("Introduce el peso en Kg");
            double peso = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("Introduce la altura en metros");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura* altura);
            if (imc >= 35)
            {
                //Obesidad tipo 2
                Console.WriteLine($"Tu IMC es de {imc.ToString("0.000")}, tienes Obesidad tipo II");
            }
            else if (imc > 30 && imc < 35)
            {
                //Obesidad tipo 1
                Console.WriteLine($"Tu IMC es de {imc.ToString("0.000")}, tienes Obesidad tipo I");
            }
            else if (imc > 27 && imc < 30)
            {
                //Sobrepeso grado 2
                Console.WriteLine($"Tu IMC es de {imc.ToString("0.000")}, tienes Sobrepeso grado II");
            }
            else if (imc > 25 && imc < 27)
            {
                //Sobrepeso grado 1
                Console.WriteLine($"Tu IMC es de {imc.ToString("0.000")}, tienes Sobrepeso grado I");
            }
            else if (imc > 18 && imc < 25)
            {
                //Normal
                Console.WriteLine($"Tu IMC es de {imc.ToString("0.000")}, Normal");
            }
            else 
            {
                //Peso insuficiente
                Console.WriteLine($"Tu IMC es de {imc.ToString("0.000")}, tienes peso insuficiente");
            }

        }
    }
}
