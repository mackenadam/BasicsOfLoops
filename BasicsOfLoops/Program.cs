﻿using System;

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
            int numberOfStudents = 21;
            Console.WriteLine("Rollcall! There are {0} seats and you should have {1} students on the bus.", numberOfSeats, numberOfStudents);
            while (counter < numberOfStudents)
            {
                Console.WriteLine("Press enter if the seat is filled, any other input means the seat is empty:");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Good, this seat has a student sitting in it!");
                    studentsAccountedFor++;
                    counter++;
                }
                else
                {
                    Console.WriteLine("This seat is empty");
                }
                Console.WriteLine(counter);
                counter += 10;
            }
        }
    }
}
