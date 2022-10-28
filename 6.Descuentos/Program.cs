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
            int unidades;
            double precio;
            double total;
            double descuento;
            Console.Write("Ingrese las Cantidad que se ha comprar: ");
            unidades = int.Parse(Console.ReadLine());


            if (unidades < 5)
            {
                precio = (unidades * 6500);
                descuento = (precio * 0.10);
                total = precio - descuento;
                Console.Write($"El precio a pagar es de: {total}");
            }
            else if (unidades >= 5 && unidades < 10)
            {
                precio = (unidades * 6500);
                descuento = (precio * 0.20);
                total = precio - descuento;
                Console.Write($"El precio a pagar es de: {total}");
            }
            else if (unidades >= 10)
            {
                precio = (unidades * 6500);
                descuento = (precio * 0.40);
                total = precio - descuento;
                Console.Write($"El precio a pagar es de: {total}");
            }
            Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
            Console.ReadKey();

        }

    }
}



