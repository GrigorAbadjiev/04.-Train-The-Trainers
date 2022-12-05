﻿using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());
            double presentationsAverageGradesSum = 0;
            int presentationCount = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    break;
                }
                presentationCount++;
                double gradesSum = 0;
                for (int i = 0; i < judgesCount; i++)
                {
                    gradesSum += double.Parse(Console.ReadLine());
                }
                presentationsAverageGradesSum += gradesSum / judgesCount;
                Console.WriteLine($"{command} - {gradesSum / judgesCount:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {presentationsAverageGradesSum / presentationCount:f2}.");
        }
    }
}
