﻿/// <summary>
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

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            Compress("aabcccccaaa");
            // aabcccccaaa => a2b1c5a3
            Compress("XXXoooxxxOOO");
            // XXXoooxxxOOO => X3o3x3O3
            Compress("abbcca");
            // abbcca => abbcca
            Compress("aabbcc");
            // aabbcc => aabbcc
            Compress("");
            // Error: the string must not be null or empty
            Compress("X".PadRight(256, 'X'));
            // Error: The length of the string must be less than 255 characters.
            Compress("a1b2c5a3");
            // Error: Only alphabetic characters [A-Z,a-z] are allowed
        }

        private static void Compress(string input)
        {
            const int MAX_LENGHT = 255;

            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: the string must not be null or empty");
            }

            if(input.Length > MAX_LENGHT)
            {
                Console.WriteLine("Error: The length of the string must be less than 255 characters.");
            }

            if(!IsAlpabethic(input))
            {
                Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed");
            }

            string StringCompressed = CompressChain(input);

            if (StringCompressed.Length >= input.Length)
            {
                StringCompressed = input;
            }

            Console.WriteLine("{0} => {1}", input, StringCompressed);

        }

        public static bool IsAlpabethic(string input)
        {
            string lowerString = input.ToLower();
            foreach (var character in lowerString)
            {
                if (!Char.IsLetter(character))
                {
                    return false;
                }
            }

            return true;
        }

        private static String CompressChain(string input)
        {
            StringBuilder sbChar = new StringBuilder();
            char CurrentCharacter = input[0];
            int contbyCharacter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(CurrentCharacter != input[i])
                {
                    sbChar.Append($"{CurrentCharacter}{contbyCharacter}");
                    CurrentCharacter = input[i];
                }
                /* sbChar.Append($"{CurrentCharacter}, {contbyCharacter}");
                CurrentCharacter = input[i]; */
                contbyCharacter++;
            }
            return sbChar.ToString();
        }
    }
}
