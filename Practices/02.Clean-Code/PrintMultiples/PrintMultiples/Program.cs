using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números del 1 al 100: ");
            PrintMultiples(100);

        }
        
        static bool CheckMultiples (int number, int multiple){

            bool TestMultiples = false;

            if (number %multiple ==0){
                TestMultiples = true;
            }
            else{
                TestMultiples = false;
            }

            return TestMultiples;
        }
    
        static void PrintMultiples (int TargetNumber ){
            int FirstNumber = 1;
        
            for (int NumberCounter = FirstNumber; NumberCounter <= TargetNumber; NumberCounter ++){

                if ((CheckMultiples(NumberCounter,5)==true)&(CheckMultiples(NumberCounter,3))){
                    Console.WriteLine ("M-3-5 ");
                }
                else if (CheckMultiples(NumberCounter,5)==true){
                    Console.WriteLine ("M-5 ");
                }

                else if (CheckMultiples(NumberCounter,3)==true){
                    Console.WriteLine ("M-3 ");
                }
                else{
                    Console.WriteLine (NumberCounter);
                }
            }
        }
    }
}

    

