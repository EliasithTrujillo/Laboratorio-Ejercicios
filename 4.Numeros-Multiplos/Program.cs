using System;

namespace Ejercicio_4
{
    class MainClass
    {
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
            C.Write("Ingrese su numero: ");
            num1 = int.Parse(Console.ReadLine());

            int num2;
            Console.Write("Ingrese su numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
                Console.WriteLine($"El numero {num2} es Múltiplo del {num1}");
            else
                Console.WriteLine($"El numero {num2} es NO Múltiplo del {num1}");

            Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
            Console.ReadKey();

        }

    }
}