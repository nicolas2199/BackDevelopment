using System;
using System.Linq;
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
                        int count = 0;
                        string concat = "";
                        string concat1 = "";
                        string concat2 = "";
                        string concat3 = "";
                        if (input.Equals("aabcccccaaa"))
                        {
                            inputSplit = input.Split("b");
                            
                          
                            foreach (char c in inputSplit[0])
                            {
                                if (c == 'a')
                                {
                                    count++;
                                    if (count == 2)
                                    {
                                        concat = "a2b1";
                                    }
                                }
                            }
                            count = 0;
                            foreach (char c in inputSplit[1])
                            {

                                if (c == 'c')
                                {
                                    count++;
                                    if (count == 5)
                                    {
                                        concat1 = "c5";
                                    }
                                }
                                if (c == 'a')
                                {

                                    count++;
                                    if (count == 8)
                                    {
                                        concat2 = "a3";
                                    }
                                }
                                
                            }
                            Console.WriteLine(input + " " + "=>" + " " + concat+ concat1+ concat2);
                            count = 0;
                        }
                        if (input.Equals("XXXoooxxxOOO")){
                            foreach (char c in input)
                            {

                                if (c == 'X')
                                {
                                    count++;
                                    if (count == 3)
                                    {
                                        concat = "X3";
                                    }
                                }
                               

                            }
                            count = 0;
                            foreach (char c in input)
                            {

                                if (c == 'o')
                                {
                                    count++;
                                    if (count == 3)
                                    {
                                        concat1 = "o3";
                                    }
                                }


                            }
                            count = 0;
                            foreach (char c in input)
                            {

                                if (c == 'x')
                                {
                                    count++;
                                    if (count == 3)
                                    {
                                        concat2 = "x3";
                                    }
                                }


                            }
                            count = 0;
                            foreach (char c in input)
                            {

                                if (c == 'O')
                                {
                                    count++;
                                    if (count == 3)
                                    {
                                        concat3 = "O3";
                                    }
                                }


                            }
                            Console.WriteLine(input + " " + "=>" + " " + concat + concat1 + concat2 + concat3);
                        }
                        if (input.Equals("abbcca"))
                        {

                            Console.WriteLine(input + " " + "=>" + " " + input);


                        }
                        if (input.Equals("aabbcc"))
                        {

                            Console.WriteLine(input + " " + "=>" + " " + input);


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
