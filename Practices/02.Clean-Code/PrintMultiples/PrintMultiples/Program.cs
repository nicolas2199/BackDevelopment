using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=1;

            while (contador<=100)
            if (MultiploTres==0){
                Console.WriteLine("M-3");                
            }
            else if (MultiploCinco==0){
                Console.WriteLine("M-5");
            }
            else if (MultiploTres==0 && MultiploCinco==0){
                Console.WriteLine("M-3-5");
            }
            Console.WriteLine(contador);
            contador +=1;

        }
        private static int MultiploTres(int contador){
            int resultado=(contador%3);
            return resultado;
        }
        
        private static int MultiploCinco(int contador){
            int resultado=(contador%5);
            return resultado;
        }
    }
}

//Write a program (c#) that prints the numbers from 1 to 100.
//But for multiples of three print "M-3" instead of the number and for the multiples of five print "M-5"
//For numbers which are multiples of both three and five print "M-3-5"
