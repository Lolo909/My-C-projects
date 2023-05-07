using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Да се състави програма, чрез която се въвежда десетична дроб. Програмата, чрез рекурсивна
              функция, да извежда въведената стойност като двоична дроб. Точността на изчисляване се
              ограничава или до указан брой знаци или до получаване на еквивалентна стойност.
              Пример: 0.125 Изход: 0.001
               дроб: 0.12444 двоична дроб с 10 знака: 0.0001111111
             */

            Console.WriteLine("Enter your fraction in decimal: ");
            double fraction = double.Parse(Console.ReadLine());


            double decNum = decimalToBinary(fraction, -1);
            Console.WriteLine("{0} to binary is {1}", fraction, decNum);

        }

        static double decimalToBinary(double fraction, int k)
        {
            double currentNum = fraction * 2.0;
            double remainder = ((int)currentNum) % 2;
            if (currentNum == 1)
            {
                return remainder * Math.Pow(10, k);
            }

            if (currentNum == fraction)
            {
                return remainder * Math.Pow(10, k);
            }
            return remainder * Math.Pow(10, k) + decimalToBinary(currentNum + remainder, k - 1);
        }

    }
}