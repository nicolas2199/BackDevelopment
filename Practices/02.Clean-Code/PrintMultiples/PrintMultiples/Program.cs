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
           string texto3="m-1";
           int variable=0;
               Console.WriteLine("prueba");


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
             Console.WriteLine("holi");

        }
        }

        public static int NumerosALetras(int value){

          if (value %3==0 )
          {
            return 5;
             }
           
           if(value %5==0){
           return 1;

          }
         
          //else if(value%3==0&&value%5==0){
            //return numeroATexto=Console.writelines( "m-3m-5");
         // }
          return 0;

          }
     
        }

        }
