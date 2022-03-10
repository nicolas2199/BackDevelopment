
using System;

namespace CompressString
{
   public class Program
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
/*         Compress("");
        // Error: the string must not be null or empty */
        Compress("X".PadRight(256, 'X'));
        // Error: The length of the string must be less than 255 characters.
        Compress("a1b2c5a3");
        // Error: Only alphabetic characters [A-Z,a-z] are allowed 
      }
     static void Compress(string input)
       {
        int MAX_LENGTH= 255;

        if (string.IsNullOrEmpty(input))
            {
             Console.WriteLine("Error: the string must not be null or empty.");
             return;
            }  

        else if (input.Length > MAX_LENGTH)
            {
             Console.WriteLine("Error: The length of the string must be less than 255 characters.");
            }

        else if(!IsAlpabethic(input)){
             Console.WriteLine("Error: Only alphabetic characters [A-Z,a-z] are allowed");
            }
        else
        {
         string ResultOfZipString = ZipString(input);
         if (ResultOfZipString.Length >= input.Length)
           {
               Console.WriteLine(input+" => "+input);
           }
         else
         {
            Console.WriteLine(input+" => "+ResultOfZipString); 
         }
       }
     }
     static string ZipString(string input)
      {
        string ZipResult = "";
        int chainLength = input.Length;
        char index = input[0];
        int number = 0;


         for(int i = 0; i < chainLength; i++)
         {
            if(index == input[i])
                {
                    number++;
                }
                else
                {
                    ZipResult += index;
                    ZipResult += number.ToString();
                    if(i + 1 < chainLength)
                    {
                        index = input[i];
                    }
                    else
                    {
                        break;
                    }
                    number = 1;
                }
            }
            ZipResult += index;
            ZipResult += number.ToString();
            
            if(ZipResult.Length < chainLength)
            {
                return ZipResult;
            }
            else
            {
                return input;
            }
      }
    static bool IsAlpabethic(string input)
     {
        string lowerString = input.ToLower();
        foreach (var character in lowerString)
        {
         if(!Char.IsLetter(character))
         {
            return false;
         }
        }
        return true;
     } 
   }
}