using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете масив от цели числа разделени с запетаи, който искате да сортирате:");

            String numbers = Console.ReadLine();

            String[] arrayOfNumbersInStringFormat = Regex.Split(numbers, @",+");

            List<int> listOfNumbers = new List<int>();
            //int[] arrayOfNumbers = new int[arrayOfNumbersInStringFormat.Length];

            foreach (string i in arrayOfNumbersInStringFormat)
            {
                listOfNumbers.Add(int.Parse(i));
            }

            Boolean isItBadSaid = true;


            Console.WriteLine("Моля кажете как искате да бъде подреден (\"възходящо\" или \"низходящо\"): ");


            while (isItBadSaid)
            {
                String whatHeSaid = Console.ReadLine().ToLower();


                if (whatHeSaid.Equals("възходящо"))
                {
                    BubbleSortAlgorithm(listOfNumbers);

                    Console.WriteLine("Ето това е резултата:");
                    foreach (int i in listOfNumbers)
                    {
                        Console.Write($"{i} ");
                    }
                    isItBadSaid = false;
                }
                else if (whatHeSaid.Equals("низходящо"))
                {

                    BubbleSortAlgorithm(listOfNumbers);
                    listOfNumbers.Reverse();

                    Console.WriteLine("Ето това е резултата:");
                    foreach (int i in listOfNumbers)
                    {
                        Console.Write($"{i} ");
                    }
                    isItBadSaid = false;
                }
                else
                {
                    Console.WriteLine("Моля повторете как искате да бъде подреден (\"възходящо\" или \"низходящо\"), че не Ви разбрах: ");
                }
            }



        }

        static void BubbleSortAlgorithm(List<int> arr)
        {
            int n = arr.Count; // Get the length of the array
            for (int i = 0; i < n - 1; i++) // Outer loop that runs n-1 times
            {
                for (int j = 0; j < n - i - 1; j++) // Inner loop that runs n-i-1 times
                {
                    if (arr[j] > arr[j + 1]) // If the current element is greater than the next element
                    {
                        int temp = arr[j]; // Swap the current element with the next element
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
 
    }
}

