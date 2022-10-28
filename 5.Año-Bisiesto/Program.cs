using System;

namespace Ejercicio_5
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
        //Se realiza el proceso del ejercicio de una manera ordenada
        static void iniciar()
        {
            int num_año;
            Console.Clear();
            Console.Write("Ingresa el año: ");
            num_año = int.Parse(Console.ReadLine());

            // Uso de % es para sacar multiplos, % es un Módulo

            if (num_año % 4 == 0)
            {
                if (num_año % 100 == 0)
                {
                    if (num_año % 400 == 0)
                    {
                        Console.WriteLine("Si es un Año Bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("No es un Año Bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Si es un Año Bisiesto");
                }
            }
            else
            {
                Console.WriteLine("No es un Año Bisiesto");
            }
            Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
            Console.ReadKey();
        }
    }
}
