using System;
using System.Text;

namespace CompressString
{
   public class Program
   {
      private const int INITIAL_VALUE = 1;
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
        if (String.IsNullOrEmpty(input))
        {
          Console.WriteLine("Error: the string must not be null or empty");
          return;
        }

        if (input.Length>255)
        {
          Console.WriteLine("Error: The length of the string must be less than 255 characters.");
          return;
        }

        if(!IsAlpabethic(input))
        {
          Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed");
          return;
        }


        string stringCompressed = CompressText(input);
        
        if (stringCompressed.Length >= input.Length)
        {
          stringCompressed = input;
        }

        Console.WriteLine("{0} => {1}", input, stringCompressed);
    
   }
      private static string CompressText(string input)
      {
        int CurrentChar;
        StringBuilder CompressedText= new StringBuilder();

        int CountCharacters = INITIAL_VALUE;
        for (CurrentChar = 0; CurrentChar < input.Length-1; CurrentChar++)
        {
         if (input[CurrentChar] == input[CurrentChar+1]){
          CountCharacters++;
         }
         else
         {
          CompressedText.Append(input[CurrentChar]);
          CompressedText.Append(CountCharacters);
          CountCharacters = INITIAL_VALUE;
         }
        }

        CompressedText.Append(input[CurrentChar]);
        CompressedText.Append(CountCharacters);

        return CompressedText.ToString();
      }

      private static bool IsAlpabethic(string input)
      {
       string lowerString = input.ToLower();
       foreach (var character in lowerString)
       {
         if (!char.IsLetter(character))
         {
           return(false);
         }
       }
       return(true);
      }
      
   }
}