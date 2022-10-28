using System;

namespace DesarioTernario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            inicial();
        }


        static void inicial()
        {
            do
            {
                Console.Clear();
                Console.Write("Ingresa una tempoeratura: ");
                int temp = Convert.ToInt32(Console.ReadLine());


                string Mensaje = temp <= 15 ? "Hace mucho frio" : temp >= 16 && temp <= 28 ? "Hace un clima agradable" : "Hace mucho calor";

                Console.WriteLine(Mensaje);

                // ? = Condición
                // : = Si no

                /*
                if (temp <= 15)
                {
                    Console.WriteLine("Hace mucho frio");
                }else if (temp <= 16 && temp >= 28)
                {
                    Console.WriteLine("Hace un clima agradable");
                }
                else
                {
                    Console.WriteLine("Hace mucho calor");
                }
                */

                Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
                Console.ReadKey();
            } while (true);
        }

    }
}
