using System;


namespace PrintMultiples
{

 internal class Program
  {
      private const int 
static void Main(string[] args)
    {
    PrintFirstHundred();
    }


    private static void PrintFirstHundred(){
        for (int currentNumber = 1; currentNumber <= 15; currentNumber++)
        {
            Console.WriteLine (CheckIfItsMultiple(currentNumber, 3));
           /* if(currentNumber%5 == 0){
            Console.WriteLine("M-5");
            }
            else
            {
            Console.WriteLine(currentNumber);
            }*/
        }
    }

    private static bool CheckIfItsMultiple(int currentNumber, int comparativeNumber){

        return(currentNumber%comparativeNumber == 0);
    }


    
}
}