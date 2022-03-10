//Santiago Varela 63421

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

namespace Parcial_Primero
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

      static string Compress(string EnteredString)
      {


          
            int StringSize = EnteredString.Length;
            int LetterRepetions = 0;
            int MaximumLength = 255;

            string CompressResult = "";
            char Letter = EnteredString[0];

            if (EnteredString.Length>MaximumLength ){
                Console.WriteLine("ERROR: String cannot be longer than 255");
            }

            if (!Number(EnteredString)){
                Console.WriteLine("ERROR: There are numbers in your text string.");
            }

            if (!Alpabethic(EnteredString)){
                Console.WriteLine("ERROR: The string is not in alphabetical form.");
            }
            else{
                for (int Position = 0; Position <StringSize ; Position++){
                if (Letter == EnteredString[Position]){
                    LetterRepetions  += 1;
                }
                else{
                    CompressResult += Letter;
                    CompressResult += LetterRepetions .ToString();
                    if ( Position + 1 < StringSize){
                        Letter = EnteredString[Position];
                    }
                    else{
                        break;
                    }
                    LetterRepetions  = 1;

                   }
                }
            }

            CompressResult += Letter;
            CompressResult += LetterRepetions .ToString();

            if(CompressResult.Length<StringSize){
                return CompressResult;
            }
            else{
                return EnteredString;
            }

        
        }

        public static bool Number(string EnteredString){
            char[] Number = {'0','1','2','3','4','5','6','7','8','9'};
            int StringSize = EnteredString.Length;
            for (int PositionString = 0; PositionString < StringSize; PositionString++){
                for (int PositionNumber = 0; PositionNumber <=9; PositionNumber ++){
                    if (EnteredString[PositionString] == Number[PositionNumber] ){
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool Alpabethic(string EnteredString){
          string lowerString = EnteredString.ToLower();
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