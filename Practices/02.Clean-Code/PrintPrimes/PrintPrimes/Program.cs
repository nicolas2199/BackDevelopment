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
      //Console.WriteLine("ola");

      int num, i, contador;
      contador =0;

      num = int.Parse(Console.ReadLine());

      for (i=1; i<=num; i++ ){

        if (num % i ==0){

          contador= contador + 1;

        }
        if (contador > 2){
          
          Console.WriteLine("{0} No es primo", num);
        }
        else{
           Console.WriteLine("{0} Es primo", num);
        }
        Console.ReadLine();
    }


  }
}
}
