
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

namespace CompressString
{
   public class Program
   {
       const int MAX_LENGTH = 250;
      public static void Main()
      {
        /* Console.WriteLine(Compress("aabcccccaaa")); 
        // aabcccccaaa => a2b1c5a3
        Console.WriteLine(Compress("XXXoooxxxOOO"));
        // XXXoooxxxOOO => X3o3x3O3
        Console.WriteLine(Compress("abbcca"));
        // abbcca => abbcca
        Console.WriteLine(Compress("aabbcc"));
        // aabbcc => aabbcc
        Console.WriteLine(Compress(""));
        // Error: the string must not be null or empty */
        Console.WriteLine(Compress("X".PadRight(256, 'X')));
        // Error: The length of the string must be less than 255 characters.
        Console.WriteLine(Compress("a1b2c5a3"));
        // Error: Only alphabetic characters [A-Z,a-z] are allowed
      }

      private static void Compress(string input)
      {
           
          

          if(string.IsNullOrEmpty(input))
          {
              Console.WriteLine("Error th string must not be null or empty");
              return;
          }


          if(input.Length > MAX_LENGTH)
          {
              Console.WriteLine("Error: The length of the string must be less than 255 characters");
          }
          
          if (!IsAlpabethic(input)){
              Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed");
          }

          string stringCompressed = compressor(input);  

          if(stringCompressed >= input.Length) 
          {
              stringCompressed =input;
          }
            

      }

    static bool IsAlpabethic(string input)
   {
       
       string lowerString = input.ToLower();
       foreach(var characters in lowerString)
       {
           if(!char.IsLetter(characters))
           {
               return false;
           }

       }

       return true;

   }
   }
}