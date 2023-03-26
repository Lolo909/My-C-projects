using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace areTheBracketsCorrect
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //         Да се напише програма със стек или опашка, която определя дали дадена последователност от скоби е правилна.
            //
            //         Примери:
            //         правилно записани скоби: (), ([]){ }, ()[], (({ })),
            //         неправилно записани:  )(, (])({), (, )})), ((())].

            

            Console.WriteLine("Въведи скоби разделени със запетая \"ПРИМЕР: (), ([]){ }, ()[], (({ }))\" :");
            String stringOfBrackets = Console.ReadLine();

            
            String[] splitedBracketsInList = Regex.Split(stringOfBrackets, @", +");

            bool isItValid = false;
            bool isItValidAll = true;

            List<string> listOfWrongBrackets= new List<string>();

            var anInstanceofMyClass = new Program();

            for (int i = 0; i < splitedBracketsInList.Length; i++)
            {
                isItValid = anInstanceofMyClass.Valid(splitedBracketsInList[i]);

                if (!isItValid)
                {
                    listOfWrongBrackets.Add(splitedBracketsInList[i]);
                    isItValidAll = false;
                }
            }

            if (isItValidAll)
            {
                Console.WriteLine("Всичките са правилни.");
            }
            else
            {
                
                String[] arrayOfWrongBrackets = listOfWrongBrackets.ToArray();

                Console.Write("Тези са неправилни: ");
                Console.WriteLine(String.Join(", ", arrayOfWrongBrackets));
                
            }

        }

        public bool Valid(String s)
        {
            Stack left = new Stack();
            s = Regex.Replace(s, @"\s+", "");

            if (!(s.ToCharArray().Length%2==0))
            {
                return false;
            }

            foreach (char c in s.ToCharArray())
            {

                if (c == '(' || c == '{' || c == '[')
                {
                    left.Push(c); // Get left
                }
                // Compare to right:
                else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(')
                {
                    left.Pop();
                }
                else if (c == '}' && left.Count != 0 && (char)left.Peek() == '{')
                {
                    left.Pop();
                }
                else if (c == ']' && left.Count != 0 && (char)left.Peek() == '[')
                {
                    left.Pop();
                }
                else
                {
                    return false; // no match
                }
            }
            return true;
        }
    }
}
