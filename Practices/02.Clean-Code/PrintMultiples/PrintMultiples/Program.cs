using System;

namespace PrintMultiples
{
    class Program
    {
        /*FORMA SIMPLE

        static void Main(string[] args)
        {

            for (int number=1; number<=100; number++){

                if (number %5 == 0 && number %3 == 0){ 
                    Console.WriteLine("M-3-5");
                }
                else if (number %3 == 0){ 
                    Console.WriteLine("M-3");
                }
                else if (number %5 == 0){ 
                    Console.WriteLine("M-5");
                }
                else{
                    Console.WriteLine(number);
                }

            } 
            
        }*/


        //CLEAN CODE
        static void Main(string[] args)
        {
            printNumbers(100);
        }

        private static void printNumbers(int maximumNumber){
            for(int countOfnumbers=1 ; countOfnumbers<=maximumNumber; countOfnumbers++){
                convertMultiples(countOfnumbers);
            }
        }

        private static void convertMultiples(int countOfnumbers){
            int multiplosDe3=0;
            int multiplosDe5=0;

            if (countOfnumbers %3 == multiplosDe3 && countOfnumbers %5 == multiplosDe5){ 
                Console.WriteLine("M-3-5");
            } 
            else if (countOfnumbers %5 == multiplosDe5){ 
                Console.WriteLine("M-5");
            }  
            else if (countOfnumbers %3 == multiplosDe3){ 
                Console.WriteLine("M-3");
            }  
            else {
                Console.WriteLine(countOfnumbers);
            }
        }
    }
}
