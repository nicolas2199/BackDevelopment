using System;
using System.Text;


namespace PrintMultiples
{

 internal class Program
  {
   
static void Main(string[] args)
    {
    PrintMultiples(100);
    }


    private static void PrintMultiples(int maxvalue){

     Console.WriteLine(GetMultiples(maxvalue));
        
    }

    private static bool CheckIfItsMultiple(int currentNumber, int baseNumber){

        return currentNumber%baseNumber == 0;
    }

    private static string GetMultiples(int maxvalue){
        StringBuilder listMultiples = new StringBuilder();

        for (int currentNumber = 1; currentNumber <= maxvalue; currentNumber++)
        {
            if (CheckIfItsMultiple(currentNumber, 3) && CheckIfItsMultiple(currentNumber, 5))
            {
            listMultiples.Append("M-3-5");   
            }
            else if(CheckIfItsMultiple(currentNumber, 5)){
            listMultiples.Append("M-5"); 
            }
            else if (CheckIfItsMultiple(currentNumber, 3))
            {
            listMultiples.Append("M-3"); 
            }
            else
            {
            listMultiples.Append(currentNumber); 
            }
            if (currentNumber<maxvalue){
                listMultiples.Append(", ");
            }
        }
        return listMultiples.ToString();

    }
    
}
}