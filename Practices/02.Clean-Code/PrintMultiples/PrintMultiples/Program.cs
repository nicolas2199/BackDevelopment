using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args){
          PrintMultiples();
        }
        
        static void PrintMultiples(){
           string mensajeMultiplo3="m-3";
           string mensajeMultiplo5="m-5";
           string mensajeMultiploAmbos="m-3m-5";
           int variable=0;
              
           for( int llenarNumeros = 0 ; llenarNumeros<=100; llenarNumeros++){
          variable=NumerosALetras(llenarNumeros);
             if (variable==3){
               
               Console.WriteLine(mensajeMultiplo3);
          
             }
            else if(variable==5){
               Console.WriteLine(mensajeMultiplo5);
             }
            else  if(variable==1){
               Console.WriteLine(mensajeMultiploAmbos);
             }
             else 
             Console.WriteLine(llenarNumeros);

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
