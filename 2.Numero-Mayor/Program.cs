using System;

namespace Ejercicio_2
{
    class MainClass
    {
        // Se declara un Ciclo para iniciar 
        public static void Main(string[] args)
        {
            do
            {
                iniciar();
                Console.WriteLine("\nEntrer continuar\n");
                Console.ReadKey();
            } while (true);

        }
        static void iniciar()
        {
            int num1;
            Console.Write("Ingrese su número: ");
            num1 = int.Parse(Console.ReadLine());

            int num2;
            Console.Write("Ingrese su número: ");
            num2 = int.Parse(Console.ReadLine());

            int num3;
            Console.Write("Ingrese su número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El {num1} numero es MAYOR");
                }
                else
                {
                    Console.WriteLine($"El {num3} numero es MAYOR");
                }
            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El {num2} numero es MAYOR");
                }
                else
                {
                    Console.WriteLine($"El {num3} numero es MAYOR");
                }
            }
            else if (num3 > num1)
            {
                if (num3 > num2)
                {
                    Console.WriteLine($"El {num3} numero es MAYOR");
                }
                else
                {
                    Console.WriteLine($"El {num2} numero es MAYOR");
                }
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"Ingrese nuevamente los datos para encontrar el mayor");
            }
            Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
            Console.ReadKey();
        }
    }
}
