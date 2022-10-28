using System;

namespace Ejercicio_4
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

            if (num1 % 2 == 0)

                Console.WriteLine($"El {num1} numero es Par");
            else
                Console.WriteLine($"El {num1} numero es Impar");


            Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
            Console.ReadKey();

        }   

    }
}

