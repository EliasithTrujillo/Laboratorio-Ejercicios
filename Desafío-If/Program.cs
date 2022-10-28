using System;

namespace Desafio_if
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
            //Ingresar
            int puntaje_obtenido; // Numero 
            string nombre_jugador;  // Nombre

            //DATOS 
            int puntación_alta = 1340;
            string nombre_jugador_punt = "Checo Pérez";

            Console.Write("Ingrese su nombre : ");
            nombre_jugador = (Console.ReadLine());

            Console.Write("Ingrese su puntuación: ");
            puntaje_obtenido = int.Parse(Console.ReadLine());


            if (puntaje_obtenido > puntación_alta)
            {
                Console.WriteLine($"La puntuación más alta es de {puntaje_obtenido}");
                Console.WriteLine($"El Puntuación obtenida por el jugador:  {nombre_jugador}");

            }
            else
            {
                Console.WriteLine($"La puntuación de {puntación_alta} no se ha llegado a superar ");
                Console.WriteLine($"La puntuación del jugador {nombre_jugador_punt} no se ha superado");

                Console.WriteLine("\nEnter para Continuar, Ctr + C para Finalizar\n");
                Console.ReadKey();
            }

        }
    }
}
