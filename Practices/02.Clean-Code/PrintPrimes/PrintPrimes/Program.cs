using System;

namespace PrintPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPrimes(13);
            // 2,3,5,7,11,13
            PrintPrimes(10);
            // 2,3,5,7
            PrintPrimes(0);
            // Error: Invalid Number
            PrintPrimes(1);
            // Error: 1 Is not Prime

        }

        private static void PrintPrimes(int maximoNumeroParaRecorrer)
        {
            for (int numeroParaValidar = 0; numeroParaValidar <= maximoNumeroParaRecorrer; numeroParaValidar++)
            {
                if (maximoNumeroParaRecorrer >= 0 && maximoNumeroParaRecorrer <= 1)
                {
                    Console.Write("Numero invalido");

                }
                else
                {

                    if (numeroParaValidar % 2 != 0)
                    {
                        //Console.Write("No es primo");
                        Console.Write(numeroParaValidar + "   ");
                    }
                }
            }
        }
    }
}
