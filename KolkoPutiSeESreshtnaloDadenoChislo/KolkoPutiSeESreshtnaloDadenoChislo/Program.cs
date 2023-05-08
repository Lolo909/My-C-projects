using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която по даден масив от цели числа в интервала [0..1000],
            намира по колко пъти се среща всяко число.
            Пример: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
            2 -> 2 пъти
            3 -> 4 пъти
            4 -> 3 пъти*/

            Console.Write("Enter your numbers with intervals: ");
            string[] input = Console.ReadLine().Split(" ");
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)

            {
                numbers[i] = int.Parse(input[i]);
            }


            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (int number in numbers)
            {
                if (!result.ContainsKey(number.ToString()))
                {
                    result.Add(number.ToString(), 1);
                }
                else
                {
                    result[number.ToString()] += 1;
                }
            }

            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine("Number {0} occurs {1}.", item.Key, item.Value);
            }

        }

    }
}