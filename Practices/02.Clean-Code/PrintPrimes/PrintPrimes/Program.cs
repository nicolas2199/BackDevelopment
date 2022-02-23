using System;

namespace PrintPrimes
{
internal class Program
{
static void Main(string[] args)
{
     
  Console.WriteLine ("\nPrimes until 13");
  PrintPrimes(13);
  // 2,3,5,7,11,13
     
  Console.WriteLine ("\nPrimes until 10");
  PrintPrimes(10);
  // 2,3,5,7
      
  Console.WriteLine ("\nPrimes until 1");
  PrintPrimes(1);
  // Error: 1 Is not Prime
      
  Console.WriteLine ("\nPrimes until 0");
  PrintPrimes(0);
      
  // Error: Invalid Number
    }
  private static void PrintPrimes(int number){
    if (number==0){
        Console.WriteLine ("\nInvalid Number\n");
      }
      else if (number==1){
        Console.WriteLine ("\n1 Is not Prime");
      }
      else{
        int cont = 0;
        for (int i = 2; i <= number; i++){  
        for (int j = 1; j <= i; j++){
          if (i % j == 0){ 
            cont = cont + 1;
               }
            }
            if (cont <= 2){ 
               Console.WriteLine(i);
            }
            cont = 0;
         }
         Console.WriteLine();
      }
    }
  }
}
