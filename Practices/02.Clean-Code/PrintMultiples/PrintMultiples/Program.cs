using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args){
          PrintMultiples();
        }
        
        static void PrintMultiples(){
           string texto1="m-3";
           string texto2="m-5";
           string texto3="m-3m-5";
           int variable=0;
              


           for( int i = 0 ; i<=100; i++){
          variable=NumerosALetras(i);
             if (variable==3){
               
               Console.WriteLine(texto1);
          
             }
            else if(variable==5){
               Console.WriteLine(texto2);
             }
            else  if(variable==1){
               Console.WriteLine(texto3);
             }
             else 
             Console.WriteLine(i);

        }

        }

        public static int NumerosALetras(int value){

          if (value %3==0 )
          {
            return 3;
             }
           
           if(value %5==0){
           return 5;

          }
         
          else if(value%3==0 && value%5==0){
          return 1 ;
          }
          return 0;

          }
     
        }

        }
