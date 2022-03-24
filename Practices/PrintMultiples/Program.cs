﻿
/// Objetivo:
///   Imprima los números del 1 a 100, separados por coma.
///   - Pero para múltiplos de tres imprima “M-3” en lugar del número
///   - Para los múltiplos de cinco imprima “M-5”
///   - Para números que son múltiplos de tres y cinco, escriba “M-3-5”
///   - Para los demas imprima solo el numero.
///  Ejemplo:
///   1,2,M-3,4,M-5,M-3,7,8,M-3,M-5,11,M-3,13,14,M-3-5,......
///
 using System;

namespace PrintMultiples{

    class Program{

        static void Main(string[] args) {
            
        //Variables para separar por comas
           String resultadoMultiplos= ""; 

            for (int numero = 1; numero <= 100; numero++)//recorre los numeros hasta 100
            {
               

                if(numero % 3 == 0)//multiplos de tres
                {
                     resultadoMultiplos = " M-3, ";
                }

                if(numero % 5 == 0)// multiplos de cinto
                {
                      
                    resultadoMultiplos = resultadoMultiplos + ", M-5 ";
                }

                if(numero % 3 == 0 && numero % 5 == 0)// multiplos de tres y cinco
                {
            
                    resultadoMultiplos = resultadoMultiplos + ", M-3-5 ";
                }
                else{

                    resultadoMultiplos = resultadoMultiplos + " " + numero;
                }

               
        }
    }
}
}