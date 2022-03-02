using System;

namespace PrintMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMultiples();            
        }

        private static void PrintMultiples()
        {
            Console.WriteLine(GetMultiples());  
        }
        private static bool IsMultipleOf(int Number, int Multiple)
        {
            return (Number % Multiple == 0);
        }

        private static string GetMultiples()
        {
            string allNumbers = "";
            for (int ListNumbers = 1; ListNumbers <= 100; ListNumbers++)
            {
                if (IsMultipleOf(ListNumbers , 3))
                {
                    if (IsMultipleOf(ListNumbers, 5))
                    {
                        allNumbers = allNumbers + "M-3-5" + ", ";
                    }else
                    {
                        allNumbers = allNumbers + "M-3" + ", ";
                    }
                }else if (IsMultipleOf(ListNumbers , 5))
                {
                    allNumbers = allNumbers + "M-5" + ", ";
                }else
                {
                    allNumbers = allNumbers + ListNumbers + ", ";
                }

                //////////////////////////////////////////////////////////////////
                /* if (IsMultipleOf(ListNumbers , 3))
                {
                    allNumbers = allNumbers + "M-3" + ", ";
                }else
                {
                    if (IsMultipleOf(ListNumbers , 5))
                    {
                        allNumbers = allNumbers + "M-5" + ", ";
                    }
                }
                if (IsMultipleOf(ListNumbers , 3))
                {
                    if (IsMultipleOf(ListNumbers, 5))
                    {
                        allNumbers = allNumbers + "M-3-5" + ", ";
                    }
                }else
                {
                    allNumbers = allNumbers + ListNumbers + ", ";
                } */
            }
            return allNumbers;
        }
    }
}
