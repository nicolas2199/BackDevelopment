using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador= 1;
            while (contador <=  100)
            
            
             if (multiploDeTres==0 && multiploDeCinco==0)
            {
                Console.WriteLine("m-3-5");
            }
            else if (multiploDeTres(contador)==0)
            {
                Console.WriteLine("m-3");
            }
             else if (multiploDeCinco==0)
            {
                Console.WriteLine("m-5");
            }
            else 
            {
                Console.WriteLine(contador);

                 }
           
            contador += 1;
        }
        private static int multiploDeTres(int contador)
        {
            int resultado = contador%3;
            return resultado;

        }
        private static int multiploDeCinco(int contador)
        {
            int resultado = contador%5;
            return resultado;

        }
        

        

    }
}



//write a program (c#) that prints the numbers from 1 to 100.
// but for multiples of three print
// "m-3" instead of the number and
// for the multi`ples of five print " m-5"
// for numbers which are multiples of both three and five print "m-3-5"

