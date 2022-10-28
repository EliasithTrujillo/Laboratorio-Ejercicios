using System;

namespace Num_Primos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            inicial();
        }

        static void inicial()
        {
            Console.Clear();
            do
            {
                int num1;
                Console.Write("Ingrese un número: ");
                num1 = int.Parse(Console.ReadLine());
         
                if ( num1 % 2 <= num1)
                {
                        Console.WriteLine($"El numero {num1} es PRIMO ");
                }
                else if (num1 % 2 == 1)
                    Console.WriteLine($"El numero NO es Primo");


            } while (true);
        }
    }
}



