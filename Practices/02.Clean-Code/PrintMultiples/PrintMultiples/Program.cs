// See https://aka.ms/new-console-template for more information
    using system; 


namespace PrimtMultiples
{
    internal class Name
    {
        static void Main(string[] args)
        {
            countNumbers();
        }

        private static void countNumbers()
        {
            for (int currentNumber = 1; currentNumber <= 100; currentNumber++)
            {
                if (isMultipleOf(currentNumber, 3) || isMultipleOf(currentNumber, 5) || 
                (isMultipleOf(currentNumber, 3) && isMultipleOf(currentNumber, 5)))
                {   
                    if (isMultipleOf(currentNumber, 3) && isMultipleOf(currentNumber, 5))
                    {
                        Console.Write("M-3-5");   
                    }else
                    {
                        if (isMultipleOf(currentNumber, 3))
                        {
                            Console.Write("M-3");   
                        }
                        if (isMultipleOf(currentNumber, 5))
                        {
                            Console.Write("M-5");   
                        }
                    }
                }
                else
                {
                    Console.Write(currentNumber);
                }
                if (currentNumber<100)
                {   
                    Console.Write(", ");
                }
            }

        }
        // encontrar multiplos de 
        private static bool isMultipleOf(int currentNumber, int baseNumber)
        {
            return currentNumber % baseNumber == 0;
        }

    }

}