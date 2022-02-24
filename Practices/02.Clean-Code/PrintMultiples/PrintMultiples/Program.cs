using System;

namespace PrintMultiples
{
    class Program
    {
        private static void generateList(int number)
        {
            bool validateMultipleThree;
            bool validateMultipleFive;
            for (int i = 1; i <= number; i++)
            {
                validateMultipleThree = validateIsMultiple(i, 3);
                validateMultipleFive = validateIsMultiple(i, 5);
                if (validateMultipleFive == true && validateMultipleThree == true)
                {
                    Console.Write("M-3-5" + "," + " ");
                }
                if (validateMultipleThree == true)
                {
                    Console.Write("M-3" + "," + " ");

                }
                else if (validateMultipleFive == true)
                {
                    Console.Write("M-5" + "," + " ");
                }
                else {
                    Console.Write(i + "," + " ");
                }

            }
        }


        private static bool validateIsMultiple(int n1, int n2)
        {
            if (n1 % n2 == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            generateList(100);
        }
    }
}
