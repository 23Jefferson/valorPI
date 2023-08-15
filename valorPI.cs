using System;

namespace CalculoPi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo Aproximado de Pi");
            Console.WriteLine("=======================");

            int terminos = 1000000; // Cantidad de términos en la serie
            double piAproximado = CalcularPiAproximado(terminos);

            Console.WriteLine($"Valor aproximado de Pi utilizando {terminos} términos: {piAproximado}");
        }

        static double CalcularPiAproximado(int terminos)
        {
            double piAproximado = 0;

            for (int i = 0; i < terminos; i++)
            {
                double termino = 4.0 / (1 + 2 * i);
                if (i % 2 == 0)
                {
                    piAproximado += termino;
                }
                else
                {
                    piAproximado -= termino;
                }
            }

            return piAproximado;
        }
    }
}