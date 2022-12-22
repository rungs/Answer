using System;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter value for print image:");
            int inputVal = Convert.ToInt32(Console.ReadLine());
            int realInput = inputVal + 1;
            Console.WriteLine($"Number more than: {inputVal}({realInput})");
            PrintImage(realInput);
        }

        public static void PrintImage(int inputVal)
        {
            Console.WriteLine($"Output: String");

            int totalAsterisk = 1;
            int numSpace = 0;
            int totalNumber = 1;

            for (int i = 1; i < inputVal - 1; i++)
            {
                totalNumber = totalNumber + 2;
            }

            for (int i = 1; i <= inputVal + 1; i++)
            {
                int totalSpace = totalNumber - numSpace;
                for (int space = 0; space <= totalSpace; space++)
                {
                    Console.Write(" ");
                }

                for (int asterisk = 0; asterisk < totalAsterisk; asterisk++)
                {
                    Console.Write("* ");
                }

                totalAsterisk = totalAsterisk + 2;
                numSpace = numSpace + 2;
                if (totalSpace == 1)
                {
                    totalAsterisk = 1;
                    numSpace = 0;
                }

                Console.WriteLine();
            }
        }
    }
}
