using System;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter gas liter:");
            int inputVal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number:Gas Liter:{inputVal}");
            CalculateDistance(inputVal);
        }

        public static void CalculateDistance(int inputVal)
        {
            int totalWheel = (inputVal * 13000);
            int distanceCm = (totalWheel * 95);
            int distanceMeter = distanceCm / 100;
            int distanceKm = distanceMeter / 1000;

            Console.WriteLine($"String: Distance ({distanceKm} KM) ");
        }
    }
}
