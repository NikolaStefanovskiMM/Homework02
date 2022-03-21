using Homework02.Entites;
using System;

namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = ReadNumbers();
            int num2 = ReadNumbers();
            int num3 = ReadNumbers();
            int num4 = ReadNumbers();
            int num5 = ReadNumbers();
            int num6 = ReadNumbers();

            int[] numberArr = new int[6];
            numberArr[0] = num1;
            numberArr[1] = num2;
            numberArr[2] = num3;
            numberArr[3] = num4;
            numberArr[4] = num5;
            numberArr[5] = num6;

            int arrResult = SumOfEven(numberArr);
            Console.WriteLine($"The result from all even numbers is: {arrResult}");


        }
        static int ReadNumbers()
        {
            Console.WriteLine("Enter a number");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            return number;
        }

        static int SumOfEven(int[] arrayOne)
        {
            //int[] arrayOne = { };
            int evenNumresult = 0;
            for (int counter = 0; counter < arrayOne.Length; counter++)
            {
                
                if (arrayOne[counter] % 2 == 0)
                {
                    evenNumresult += arrayOne[counter];
                }
            }
            return evenNumresult;
        }

    }
}
