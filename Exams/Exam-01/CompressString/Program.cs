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
            const int MaxLength = 255;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: the string must not be null or empty");
                return;
            }
            if (input.Length > MaxLength)
            {
                Console.WriteLine("Error: The length of the string must be less than 255 characters.");
                return;
            }
            if (HaveNumber(input))
            {
                Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed");
                return;
            }

            string StringCompress = CompressTheString(input);

            if (StringCompress.Length >= input.Length)
            {
                StringCompress = input;
            }


            Console.WriteLine($"{input} => {StringCompress}");


        }

        private static bool HaveNumber(string input)
        {
            string lowerString = input.ToLower();
            foreach (char item in lowerString)
            {
                if (!Char.IsLetter(item))
                {
                    return true;
                }
            }
            return false;
        }

        private static string CompressTheString(string input)
        {
            int contCharater = 0;
            char lastCharater = ' ';
            StringBuilder SBCompressString = new StringBuilder();
            for (int i = 0; i <= input.Length-1; i++)
            {
                if (lastCharater == ' ')
                {
                    lastCharater = input[i];
                }
                if (lastCharater == input[i])
                {
                    contCharater++;
                }
                else
                {
                    SBCompressString.Append($"{lastCharater}{contCharater}");
                    contCharater = 1;
                    lastCharater = input[i];
                }
                if(i == input.Length-1)
                {
                    SBCompressString.Append($"{lastCharater}{contCharater}");
                }


            }

            return SBCompressString.ToString();
        }
    }
}
