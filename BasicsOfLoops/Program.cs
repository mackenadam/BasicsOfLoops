using System;

namespace BasicsOfLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to loops in C#
            // For loops
            Console.WriteLine("For loop example:");
            for (int i = 10; i >= 0; i--)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Blast off!");
                }
            }

            Console.WriteLine("...");

            // Do while loops
            Console.WriteLine("Do while loop example:");
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string currentName = Console.ReadLine();
                int currentLength = currentName.Length;
                lengthOfText += currentLength;
                wholeText += currentName + " ";
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough names: {0}", wholeText);

            Console.WriteLine("...");

            // While loops
            Console.WriteLine("While loop example:");
            int counter = 0;
            int studentsAccountedFor = 0;
            int missingStudents = 0;
            int numberOfStudents = 21;
            Console.WriteLine("Rollcall! You should have {0} students on the bus.", numberOfStudents);
            while (counter < numberOfStudents)
            {
                Console.WriteLine("Press enter if the seat is filled, any other input means the seat is empty:");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    studentsAccountedFor++;
                    counter++;
                    Console.WriteLine("Good, this seat has a student sitting in it! {0} people are on the bus.", studentsAccountedFor);
                }
                else
                {
                    missingStudents++;
                    counter++;
                    Console.WriteLine("This seat is empty. You are missing {0} students.", missingStudents);
                }
            }
            Console.WriteLine("You have counted all {0} students on the bus, {1} are still unaccounted for.", studentsAccountedFor, missingStudents);
        }
    }
}
