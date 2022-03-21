using System;

namespace Homework_02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsGOne = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsGTwo = { "Zoki", "Mile", "Brus", "Petko", "Vele" };

            Console.WriteLine("Enter student group: ");
            string input = Console.ReadLine();
            bool isParsed = int.TryParse(input, out int studentGroup);
            if (!isParsed)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            switch (studentGroup)
            {
                case 1:
                    Console.WriteLine($"The student from G1 are: \n {studentsGOne[0]}, {studentsGOne[1]}, {studentsGOne[2]}, {studentsGOne[3]}, {studentsGOne[4]}.");
                    break;
                case 2:
                    Console.WriteLine($"The student from G1 are: \n {studentsGTwo[0]}, {studentsGTwo[1]}, {studentsGTwo[2]}, {studentsGTwo[3]}, {studentsGTwo[4]}.");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}
