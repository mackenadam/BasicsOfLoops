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
            int numberOfStudents = 23;
            Console.WriteLine("You should have {0} students on the bus.");
            while (counter < 100)
            {

                Console.WriteLine(counter);
                counter += 10;
            }
        }
    }
}
