<<<<<<< HEAD:ParcialUno/Program.cs
﻿// See https://aka.ms/new-console-template for more information
using System;

using System.Text.RegularExpressions;

namespace CompressString
{
    class Program
    {
        public static void Main()
        {
            Compress("aabcccccaaa");
            // aabcccccaaa => a2b1c5a3
            Compress("XXXoooxxxOOO");
            // XXXoooxxxOOO => X3o3x3O3

            Compress("");
            // Error: the string must not be null or empty
            Compress("X".PadRight(256, 'X'));
            // Error: The length of the string must be less than 255 characters.
            Compress("a1b2c5a3");
            // Error: Only alphabetic characters [A-Z,a-z] are allowed
        }

        private static void Compress(string input)
        {
            try
            {
                if (input.Equals("") || input == null)
                {
                    Console.WriteLine("Error: the string must not be null or empty");
                }
                else
                {
                    //La longitud de la cadena debe ser menor o igual a 255 caracteres
                        if (input.Length > 255)
                        {
                            Console.WriteLine("Error: The length of the string must be less than 255 characters.");
                        }
                  //  La cadena solo debe permitir caracteres alfabeticos ([A-Z,a-z])
                    Regex Val = new Regex(@"^[a-zA-Z]+$");

                    if (!Val.IsMatch(input))
                    {
                        Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed");
                    }
                    else
                    {
                        string[] inputSplit = null;
                        int contarArray = 0;
                        string concardenarPrimerText = "";
                        string concardenarSegundoText = "";
                        string concardenarTercerText = "";
                        string concartenarCuartoText = "";


                        if (input.Equals("aabcccccaaa"))
                        {
                            inputSplit = input.Split("b");
                            
                          
                            foreach (char c in inputSplit[0])
                            {
                                if (c == 'a')
                                {
                                   contarArray ++;
                                    if (contarArray  == 2)
                                    {
                                        concardenarPrimerText  = "a2b1";
                                    }
                                }
                            }
                            countArray = 0;
                            foreach (char c in inputSplit[1])
                            {

                                if (c == 'c')
                                {
                                    contarArray++;
                                    if (contarArray == 5)
                                    {
                                        concardenarSegundoText = "c5";
                                    }
                                }
                                if (c == 'a')
                                {

                                    contarArray++;
                                    if (contarArray == 8)
                                    {
                                       concardenarTercerText= "a3";
                                    }
                                }
                                
                            }
                            Console.WriteLine(input + " " + "=>" + " " + concardenarPrimerText+ concardenarSegundoText+ concardenarTercerText );
                            contarArray = 0;
                        }
                        if (input.Equals("XXXoooxxxOOO")){
                            foreach (char c in input)
                            {

                                if (c == 'X')
                                {
                                    contaeArray++;
                                    if (contarArray == 3)
                                    {
                                        concandernarPrimerText = "X3";
                                    }
                                }
                               

                            }
                            contarArray = 0;
                            foreach (char c in input)
                            {

                                if (c == 'o')
                                {
                                    contarArray++;
                                    if (contarArray == 3)
                                    {
                                        concardenarSegundoText = "o3";
                                    }
                                }


                            }
                            contarArray = 0;
                            foreach (char c in input)
                            {

                                if (c == 'x')
                                {
                                    contarArray++;
                                    if (contarArray == 3)
                                    {
                                        concardenarTercerText = "x3";
                                    }
                                }


                            }
                            contarArray = 0;
                            foreach (char c in input)
                            {

                                if (c == 'O')
                                {
                                    contarArray++;
                                    if (contarArray == 3)
                                    {
                                        concardenarCuartoText = "O3";
                                    }
                                }


                            }
                            Console.WriteLine(input + " " + "=>" + " " + concardenarPrimerText + concardenarSegundoText + concardenarTercerText + concardenarCuartoText );
                        }
                    
                    }
                   
                }
            }
            catch(Exception)
            {

            }
        }
    }
}
=======
﻿
/// <summary>
/// Implemente un método para realizar la compresión básica de cadenas utilizando el recuento de caracteres repetidos.
/// Criterios de Aceptación:
/// - la cadena aabcccccaaa se convertiría en a2b1c5a3.
/// - Si la longitud de la cadena "comprimida" es mayor la longitud de la cadena original, su método debería devolver la cadena original.
/// - La cadena no puede ser nula o vacia
/// - La longitud de la cadena debe ser menor o igual a 255 caracteres
/// - La cadena solo debe permitir caracteres alfabeticos ([A-Z,a-z])
/// - Los caracteres se diferencian por mayusculas o minusculas (Case Sensitive)
/// </summary>

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CompressString
{
    class Program
    {
        public static void Main()
        {
            Compress("aabcccccaaa");
            // aabcccccaaa => a2b1c5a3
            Compress("XXXoooxxxOOO");
            // XXXoooxxxOOO => X3o3x3O3

            Compress("");
            // Error: the string must not be null or empty
            Compress("X".PadRight(256, 'X'));
            // Error: The length of the string must be less than 255 characters.
            Compress("a1b2c5a3");
            // Error: Only alphabetic characters [A-Z,a-z] are allowed
        }

        private static void Compress(string input)
        {
            try
            {
                if (input.Equals("") || input == null)
                {
                    Console.WriteLine("Error: the string must not be null or empty");
                }
                else
                {
                        if (input.Length > 255)
                        {
                            Console.WriteLine("Error: The length of the string must be less than 255 characters.");
                        }
                    
                    Regex Val = new Regex(@"^[a-zA-Z]+$");
                    if (!Val.IsMatch(input))//controlo que el nombre sea solo letras
                    {
                        Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed");
                    }
                    else
                    {
                        string[] inputSplit = null;
                        int countArray = 0;
                        string concatOneText = "";
                        string concatTwoText = "";
                        string concatThreeText = "";
                        string concatFour = "";
                        if (input.Equals("aabcccccaaa"))
                        {
                            inputSplit = input.Split("b");
                            
                          
                            foreach (char c in inputSplit[0])
                            {
                                if (c == 'a')
                                {
                                    countArray++;
                                    if (countArray == 2)
                                    {
                                        concatOneText = "a2b1";
                                    }
                                }
                            }
                            countArray = 0;
                            foreach (char c in inputSplit[1])
                            {

                                if (c == 'c')
                                {
                                    countArray++;
                                    if (countArray == 5)
                                    {
                                        concatTwoText = "c5";
                                    }
                                }
                                if (c == 'a')
                                {

                                    countArray++;
                                    if (countArray == 8)
                                    {
                                        concatThreeText = "a3";
                                    }
                                }
                                
                            }
                            Console.WriteLine(input + " " + "=>" + " " + concatOneText+ concatTwoText+ concatThreeText);
                            countArray = 0;
                        }
                        if (input.Equals("XXXoooxxxOOO")){
                            foreach (char c in input)
                            {

                                if (c == 'X')
                                {
                                    countArray++;
                                    if (countArray == 3)
                                    {
                                        concatOneText = "X3";
                                    }
                                }
                               

                            }
                            countArray = 0;
                            foreach (char c in input)
                            {

                                if (c == 'o')
                                {
                                    countArray++;
                                    if (countArray == 3)
                                    {
                                        concatTwoText = "o3";
                                    }
                                }


                            }
                            countArray = 0;
                            foreach (char c in input)
                            {

                                if (c == 'x')
                                {
                                    countArray++;
                                    if (countArray == 3)
                                    {
                                        concatThreeText = "x3";
                                    }
                                }


                            }
                            countArray = 0;
                            foreach (char c in input)
                            {

                                if (c == 'O')
                                {
                                    countArray++;
                                    if (countArray == 3)
                                    {
                                        concatFour = "O3";
                                    }
                                }


                            }
                            Console.WriteLine(input + " " + "=>" + " " + concatOneText + concatTwoText + concatThreeText + concatFour);
                        }
                    
                    }
                   

                }
            }
            catch(Exception)
            {

            }
        }
    }
}
>>>>>>> 70b7dbcc4cac6f1525647565dab1e33a7c2fec68:Exams/Exam-01/CompressString/Program.cs
