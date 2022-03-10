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
      public static void Main(string[] args)
      {
        
        //Console.WriteLine(Compress(""));
        // Error: the string must not be null or empty
        Console.WriteLine(Compress("aabcccccaaa"));
        // aabcccccaaa => a2b1c5a3
        Console.WriteLine(Compress("XXXoooxxxOOO"));
        // XXXoooxxxOOO => X3o3x3O3
        Console.WriteLine(Compress("abbcca"));
        // abbcca => abbcca
        Console.WriteLine(Compress("aabbcc"));
        // aabbcc => aabbcc
        Console.WriteLine(Compress("X".PadRight(256, 'X')));
        // Error: The length of the string must be less than 255 characters.
        Console.WriteLine(Compress("a1b2c5a3"));
        // Error: Only alphabetic characters [A-Z,a-z] are allowed
      }

      static string Compress(string input)
      {
        int stringSize = input.Length;
            string zipResult = "";
            int MAX_LENGTH = 255;
            char compareLetter = input[0];
            int repetitions = 0;

            if (input.Length>MAX_LENGTH){
                Console.WriteLine("Error: The length of the string must be less than 255 characters.");
            }

            if (!IsAlpabethic(input)){
                Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed.");
            }
            else{
                for (int position = 0; position < stringSize; position++){
                if (compareLetter == input[position]){
                    repetitions += 1;
                }
                else{
                    zipResult += compareLetter;
                    zipResult += repetitions.ToString();
                    if ( position + 1 < stringSize){
                        compareLetter = input[position];
                    }
                    else{
                        break;
                    }
                    repetitions = 1;

                   }
                }
            }

            zipResult += compareLetter;
            zipResult += repetitions.ToString();

            if(zipResult.Length<stringSize){
                return zipResult;
            }
            else{
                return input;
            }


        }
        public static bool IsAlpabethic(string input){
          string lowerString = input.ToLower();
          foreach (var character in lowerString)
          {
              if(!Char.IsLetter(character)){
                  return false;
              }
          }
          return true;
      }
      }

   }
