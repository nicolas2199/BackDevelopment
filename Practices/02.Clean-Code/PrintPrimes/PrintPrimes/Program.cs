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

    private static void PrintPrimes(int number)
    {
     int contador= 0;
     int numeroInicial=1;

     while(numeroInicial <= 13){
       for (int i =1; i<= number);
     }
     
    }
  }
}
