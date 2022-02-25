using System;

namespace PrinMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 100");
            for (int number=1;number<=100;number++){
               
                if(number%3==0){
                    Console.WriteLine(number+" M-3 ");
                }
                else if(number%5==0){
                     Console.WriteLine(number+" M-5 ");
                }
                else if(number%15==0){
                    Console.WriteLine(number+" M-3-5 ");
                }
                else{
                     Console.WriteLine(number);
                }
            }
        }
    }
}
//Write a program that prints the numbers from 1 to 100
//But fot multiples of three print "M-3" instead of the number and for multiples of 5 print "M-5"
//For numbers which are multiples of both 3 and 5 print "M-3-5" 
// Commit testing
