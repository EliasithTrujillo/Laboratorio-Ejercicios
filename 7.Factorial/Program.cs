using System;

namespace Ejercicio_7
{
    class MainClass
    {
        public static int Main(string[] args)
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
            int contador;
            int num;
            int factorial = 1;

            Console.Write($"El ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (contador = 1; contador <= num; contador++)
            {
                factorial = factorial * contador;
            }
            Console.WriteLine($"El factorial del número es {factorial}");

            Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
            Console.ReadKey();
        }
    }
}
