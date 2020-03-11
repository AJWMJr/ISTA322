using System;
using System.Collections.Generic;

namespace RouletteTesting
{
    class Program
    {
        private const int numCols = 3;
        private const int colSize = 12;
        enum Column { First, Second, Third}
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> columns = new Dictionary<string, List<int>>(numCols);
            for (Column cols = Column.First; cols < Column.Third; cols++)
            {
                List<int> nums = new List<int>(colSize);
                for (int i = 1; i <= colSize; i++)
                {
                    nums.Add(i);
                }
                columns.Add(cols.ToString(), nums);
            }
            Position pos = new Position();
            Nav();
        }
        private static void Nav()
        {
            string choice, result;
            int c;
            Console.WriteLine("Let's play some Roulette!");
            Console.WriteLine("Place your bets:");
            Console.WriteLine("    1) Bet single number");
            Console.WriteLine("    2) Bet evens or odds");
            Console.WriteLine("    3) Bet red or black");
            Console.WriteLine("    4) Bet low or high");
            Console.WriteLine("    5) Bet Thirds");
            Console.WriteLine("    6) Bet Columns");
            Console.WriteLine("    7) Bet streets/rows");
            Console.WriteLine("    8) Bet a split");
            Console.WriteLine("    9) Bet a corner");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.Write("please enter a number between 1 and 36: ");
                choice = Console.ReadLine();
                chkParse(choice);
                c = int.Parse(choice);
                if (c < 1 || c > 36)
                    badInput();
                else
                    strChoice(choice);
            }
            else if (input == 2)
            {
                Console.Write("Odd or Even? type O or E: ");
                choice = Console.ReadLine();
                result = letterChoice(choice, "E", "O");
                if (result == "E")
                    strChoice("Even");
                else if (result == "O")
                    strChoice("Odd");
                else
                    Nav();
            }
            else if (input == 3)
            {
                Console.Write("Red or Black? type R or B: ");
                choice = Console.ReadLine();
                result = letterChoice(choice, "R", "B");
                if (result == "R")
                    strChoice("Red");
                else
                    strChoice("Black");
            }
            else if (input == 4)
            {
                Console.Write("Do you want Lows (1-18) or highs (19-36)? type L or H: ");
                choice = Console.ReadLine();
                result = letterChoice(choice, "L", "H");
                if (result == "L")
                    strChoice("Lower");
                else
                    strChoice("Higher");
            }
            else if (input == 5)
            {
                Console.Write("1st dozen, 2nd dozen, or 3rd dozen? type 1, 2, or 3: ");
                choice = Console.ReadLine();
                ThreeOptions(choice);
            }
            else if (input == 6)
            {
                Console.Write("1st column, 2nd column, or 3rd column? type 1, 2, or 3");
                choice = Console.ReadLine();
                result = ThreeOptions(choice);
                // NEED TO ADDRESS OVERLAP OF strChoice(ED VALUES BETWEEN COLUMNS AND DOZENS
            }
            else if (input == 7)
            {
                Console.Write("pick a street use this last number in the street [example for the first street (1/2/3) type 3, etc.]");
                choice = Console.ReadLine();
                chkParse(choice);
                c = int.Parse(choice);
                int[] street = new int[3];
                for (int i = 0; i < street.Length - 1; i++)
                {
                    street[i] = c - i;
                }
                arrChoice(street);
            }
            else if (input == 8)
            {

            }
            else if (input == 9)
            {

            }
        }

        private static void arrChoice(int[] A)
        {
            throw new NotImplementedException();
        }

        private static void strChoice(string choice)
        {
            throw new NotImplementedException();
        }

        private static string letterChoice(string choice, string L1, string L2)
        {
            if ((choice == L1) || (choice == L1.ToLower())) { return L1; }
            if ((choice == L2) || (choice == L2.ToLower())) { return L2; }
            else
            {
                Console.WriteLine("Invalid choice. strChoice(ing to main menu");
                return "fail";
            }
        }
        private static void badInput()
        {
            Console.WriteLine("Invalid. strChoice(ing to main menu");
            Nav();
        }
        private static int chkParse(string choice)
        {
            int c;
            try { c = int.Parse(choice); }
            catch { badInput(); }
            c = int.Parse(choice);
            return c;
        }
        private static string ThreeOptions(string choice)
        {
            int c = chkParse(choice);
            if (c < 1 || c > 3)
                badInput();
            if (c == 1)
                return "First";
            else if (c == 2)
                return "Second";
            else if (c == 3)
                return "Third";
            else
                return null;
        }
    }
}
