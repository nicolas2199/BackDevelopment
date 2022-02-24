using System;

namespace PrinMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Del 1 al 100");
            for (int i=1;i<=100;i++){
               
                if(i%15==0){
                    Console.WriteLine("Numero: "+i+" M-3-5");
                }
                else if(i%5==0){
                     Console.WriteLine("Numero: "+i+" M-5");
                }
                else if(x%3==0){
                    Console.WriteLine("Numero: "+i+" M-3");
                }
                else{
                     Console.WriteLine("Numero: "+i);
                }
            }
        }
    }
}
//Write a program that prints the numbers from 1 to 100
//But fot multiples of three print "M-3" instead of the number and for multiples of 5 print "M-5"
//For numbers which are multiples of both 3 and 5 print "M-3-5" 
// Commit testing
