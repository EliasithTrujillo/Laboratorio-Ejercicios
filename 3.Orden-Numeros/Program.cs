using System;

namespace Ejercicio_3
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
        //DATOS
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

            //MAYOR
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El {num1} numero es Mayor");
                }
            }
            if (num2 > num3)
            {
                if (num2 > num1)
                {
                    Console.WriteLine($"El {num2} numero es Mayor");
                }
            }
            if (num3 > num2)
            {
                if (num3 > num1)
                {
                    Console.WriteLine($"El {num3} numero es Mayor");
                }
            }

            //MEDIO
            if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine($"El {num1} numero es Medio");

            }
            if (num2 > num1 && num2 < num3)
            {
                Console.WriteLine($"El {num2} numero es Medio");

            }
            if (num3 > num1 && num3 < num2)
            {
                Console.WriteLine($"El {num3} numero es Medio");

            }

            //MAYOR
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine($"El {num1} numero es Menor");
                }
            }
            if (num2 < num3)
            {
                if (num2 < num1)
                {
                    Console.WriteLine($"El {num2} numero es Menor");
                }
            }
            if (num3 < num2)
            {
                if (num3 < num1)
                {
                    Console.WriteLine($"El {num3} numero es Menor");
                }
            }
            Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
            Console.ReadKey();

        }
    }
}
