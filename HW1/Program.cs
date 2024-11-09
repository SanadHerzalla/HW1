using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter minumum number: ");
                int minNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter maxiumum number: ");
                int maxNumber = int.Parse(Console.ReadLine());

                if (minNumber > maxNumber)
                {
                    Console.WriteLine("minumum number should be lower than the maxiumum number");
                    return;
                }

                
                int[] frequency = new int[maxNumber - minNumber + 1];
                /* (+1) because array starts from index 0
                so to make sure we have all numbers
                int the range*/

                Random random = new Random();

                
                for (int i = 0; i < 1000; i++)
                {
                    int number = random.Next(minNumber, maxNumber + 1);
                    frequency[number - minNumber]++;
                }

                Console.WriteLine("\nNumber\t\tFrequency");
                for (int i = 0; i < frequency.Length; i++)
                {
                    Console.WriteLine((i + minNumber) + "\t\t" + frequency[i]);
                }
            
        }
    }
}
