using System;

namespace PrintMultiples {
    public class Program {
        static void Main(string[] args) {
            PrintMultiples();
        }

        private static void PrintMultiples() {
            for (int i = 1; i <= 100; i++) {
                if (FindMultiple(i) == 3) {
                    Console.Write("M-3, ");
                }
                if (FindMultiple(i) == 5) {
                    Console.Write("M-5, ");
                }
                if (FindMultiple(i) == 1) {
                    Console.Write("M-3-5, ");
                }
                if (FindMultiple(i) == 0) {
                    Console.Write($"{i}, ");
                }
            }
        }

        public static int FindMultiple(int number) {
            if (number % 3 == 0) {
                if (number % 5 == 0) {
                    return 1;
                }
                return 3;
            }
            if (number % 5 == 0) {
                return 5;
            }
            return 0;
        }
    }
}
