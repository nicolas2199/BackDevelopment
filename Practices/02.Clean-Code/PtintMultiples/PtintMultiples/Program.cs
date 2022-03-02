using System;

namespace PrinMultiples
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* numeros del 1 al 100 */ 
            /* cada multiplo de 3  se escribe m-3 */
            /* cada multiplo de 5 se escribe M-5 */
           /* si es multiplo de ambos se escribe m-3-5 */
            Console.WriteLine("Del 1 al 100");
            printmultiples();
        }

        private static void printmultiples(){
            
            for (int increase_Number=1;increase_Number<=100;increase_Number++){
               
                if(increase_Number%15==0){
                    Console.Write(increase_Number+" M-3-5, ");
                }
                else if(increase_Number%5==0){
                     Console.Write(increase_Number+" M-5, ");
                }
                else if(increase_Number%3==0){
                    Console.Write(increase_Number+" M-3, ");
                }
                else{
                     Console.Write(increase_Number+", ");
                }
            }
        }
    }
}
