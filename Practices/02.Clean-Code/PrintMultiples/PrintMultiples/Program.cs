using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultiples();
        }

        static void PrintMultiples()
        {
            string mensajeMultiplo3 = "m-3";
            string mensajeMultiplo5 = "m-5";
            string mensajeMultiploAmbos = "m-3m-5";
            int variable = 0;

            for (int llenarNumeros = 0; llenarNumeros <= 100; llenarNumeros++)
            {
                variable = NumerosALetras(llenarNumeros);
                if (variable == 3)
                {

                    Console.WriteLine(mensajeMultiplo3);

                }
                else if (variable == 5)
                {
                    Console.WriteLine(mensajeMultiplo5);
                }
                else if (variable == 1)
                {
                    Console.WriteLine(mensajeMultiploAmbos);
                }
                else
                    Console.WriteLine(llenarNumeros);

            }

        }
        private static int multiploDeTres(int numero)
        {
            int resultado = numero % 3;
            return resultado;

        }
        private static int multiploDeCinco(int numero)
        {
            int resultado = numero % 5;
            return resultado;

        }


        public static int NumerosALetras(int numero)
        {
            if (multiploDeTres(numero) == 0 && multiploDeCinco(numero) == 0)
            {
                return 1;
            }

            else if (multiploDeTres(numero) == 0)
            {
                return 3;
            }

            else if (multiploDeCinco(numero) == 0)
            {
                return 5;

            }

            return 0;

        }

    }

}
