using System;
using System.Collections.Generic;

namespace largestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');

            string output = "";

            List<string> counts = new List<string>();
            GetLargestCommonEnd(input, input2, counts);

            Array.Reverse(input);
            Array.Reverse(input2);
            List<string> countsReverse = new List<string>();
            GetLargestCommonEnd(input, input2, countsReverse);

            List<string> maxCounts = new List<string>();
            var notValid = counts.Count == 0 && countsReverse.Count == 0;

            if (notValid)
            {
                output = "No common words at the left and right";
            }
            else if (counts.Count >= countsReverse.Count)
            {
                maxCounts = counts;
                output = "left";
            }
            else
            {
                maxCounts = countsReverse;
                maxCounts.Reverse();
                output = "right";
            }

            GetPrint(maxCounts, output);           
        }

        static void GetLargestCommonEnd(string[] firstArray, string[] secondArray, List<string> listOfTexts)
        {
            int test = 0;

            while (test < Math.Min(firstArray.Length, secondArray.Length))
            {
                if (firstArray[test] == secondArray[test])
                {
                    listOfTexts.Add(firstArray[test]);
                }

                test++;
            }
        }

        static void GetPrint(List<string> listOfTexts, string endInput)
        {
            if (listOfTexts.Count.Equals(0))
            {
                Console.WriteLine(endInput);
            }
            else
            {
                Console.Write($"The largest common end is at the {endInput}: ");
                foreach (var item in listOfTexts)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
        }
    }
}
