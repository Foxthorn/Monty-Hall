using System;

namespace MontyHall
{
    internal class Program
    {
        //Red is safe
        private static void Main(string[] args)
        {
            Random rng = new Random();
            int numberOfDeathsKeep = 0;
            int numberOfDeathChange = 0;
            for (int i = 0; i <= 100000; i++)
            {
                int choice = rng.Next(0, 3);
                int removed = rng.Next(0, 3);
                while (removed == choice || removed == 0)
                {
                    removed = rng.Next(0, 3);
                }
                int choiceChange = ChangeChoice(choice, removed);
                if (choiceChange != 0)
                {
                    numberOfDeathChange++;
                }
                if (choice != 0)
                {
                    numberOfDeathsKeep++;
                }
            }
            double deathPercentage = (double)numberOfDeathsKeep / 100000 * 100;
            Console.WriteLine("Keep Pill Tests: 100000, Died: " + numberOfDeathsKeep + " times, Death Percentage: " + deathPercentage);
            deathPercentage = (double)numberOfDeathChange / 100000 * 100;
            Console.WriteLine("Change Pill Tests: 100000, Died: " + numberOfDeathChange + " times, Death Percentage: " + deathPercentage);
            Console.ReadLine();
        }

        static int ChangeChoice(int choice, int removed)
        {
            int change = 0;
            for (int i = 0; i < 3; i++)
            {
                if (choice == i)
                {
                    continue;
                }
                if (removed == i)
                {
                    continue;
                }
                change = i;
            }
            return change;
        }
    }
}