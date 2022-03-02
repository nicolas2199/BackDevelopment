using System;
namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros del 1 al 100");
            PrintMultiples(100);
        }
        static bool ValidMultiples(int number, int multiple){
            bool AttributeOfMultiple = false;
            if (number %multiple ==0){
                AttributeOfMultiple = true;
            }
            else
            {
                AttributeOfMultiple = false;
            }

            return AttributeOfMultiple;
        }
        static void PrintMultiples( int number)
        {
            int InicialNumber = 1;
            int LastNumber = number;
            for (int CountNumber = InicialNumber; CountNumber <=LastNumber; CountNumber++){
                if((ValidMultiples(CountNumber,5)==true) & (ValidMultiples(CountNumber,3)==true)){
                    Console.WriteLine ("M-3-5");
                }
                else if (ValidMultiples(CountNumber,5)==true)
                {
                    Console.WriteLine("M-5");
                }
                else if (ValidMultiples(CountNumber,3)==true)
                {
                    Console.WriteLine("M-3");
                }
                else
                {
                    Console.WriteLine(CountNumber);
                }
            } 
        }
    }
}
