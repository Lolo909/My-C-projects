using System;
using System.Collections;

namespace FindPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue palindromQueueFirstHalf = new Queue();
            Stack palindromStackSecondHalf = new Stack();

            Boolean isItPalindrom = false;

            Console.WriteLine("Въвъди дължината на числото което ще въведете: ");
            int lengthOfNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Въвъди числото: ");
            String input = Console.ReadLine();



            while (input.Length != lengthOfNumber)
            {
                Console.WriteLine("Дължината на числото ви трябва да е {0}. Моля въведи правилен инпyт:", lengthOfNumber);

                input = Console.ReadLine();
            }

            int l = lengthOfNumber / 2;
                for (int i = 0; i < lengthOfNumber/2; i++)
                {
                    palindromQueueFirstHalf.Enqueue(input.Substring(i,1));
                }

                for (int i = lengthOfNumber/2; i < lengthOfNumber; i++)
                {
                    palindromStackSecondHalf.Push(input.Substring(i, 1));
                }


            //proverka
           
            int lenght = palindromQueueFirstHalf.Count;
            

            for (int i = 0; i < lenght; i++)
            {
                
                if (palindromQueueFirstHalf.Dequeue().Equals(palindromStackSecondHalf.Pop()))
                {
                    isItPalindrom = true;
                }
                else
                {
                    isItPalindrom = false;
                    break;
                }
            }

            if (isItPalindrom)
            {
                Console.WriteLine("Да палиндром е: {0}", input);
            }
            else
            {
                Console.WriteLine("Не е палиндром: {0}", input);
            }
        }
    }
}
