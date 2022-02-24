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

<<<<<<< HEAD
    private static void PrintPrimes(int number)
    {
     int contador= 0;
     int numeroInicial=1;

     while(numeroInicial <= 13){
       for (int i =1; i<= number);
     }
     
=======
        private static void PrintPrimes(int number)
        {
            int contador = 0;


            for (int i = 1; i < (number + 1); i++)
            {
                if (number % i == 0)
                {
                    contador++;
                }
            }
            if (number == 0)
            {
                Console.WriteLine("Error: Numero invalido");
            }
            if (contador != 2)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("1 no es primo");
            }

        }
>>>>>>> 780c2e7451ce5cc0c94e969fc699a81cbe2228d1
    }
}



