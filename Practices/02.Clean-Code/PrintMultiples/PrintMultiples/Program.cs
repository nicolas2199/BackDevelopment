using System;

namespace PrintMultiples
{
    class Program
    {
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
            
        }
    }
}
