using System;
using System.Collections.Generic;
using System.Linq;

namespace Roulette
{
    class Program
    {
        enum Column { First, Second, Third };
        static void Main(string[] args)
        {
            Nav();
        }
        private static void Nav()
        {
            string choice;
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
                c = chkParse(choice);
                if (c < 1 || c > 36)
                    badInput();
                else
                    strChoice(choice);
            }
            else if (input == 2)
            {
                Console.Write("Odd or Even? type O or E: ");
                choice = Console.ReadLine();
                choice.ToUpper();
                letterChoice(choice, "E", "O");
            }
            else if (input == 3)
            {
                Console.Write("Red or Black? type R or B: ");
                choice = Console.ReadLine();
                choice.ToUpper();
                letterChoice(choice, "R", "B");
            }
            else if (input == 4)
            {
                Console.Write("Do you want Lows (1-18) or highs (19-36)? type L or H: ");
                choice = Console.ReadLine();
                choice.ToUpper();
                letterChoice(choice, "L", "H");
            }
            else if (input == 5)
            {
                Console.Write("1st dozen, 2nd dozen, or 3rd dozen? type 1, 2, or 3: ");
                choice = Console.ReadLine();
                ThreeOptions(choice, 'D');
            }
            else if (input == 6)
            {
                Console.Write("1st column, 2nd column, or 3rd column? type 1, 2, or 3");
                choice = Console.ReadLine();
                ThreeOptions(choice, 'C');
            }
            else if (input == 7)
            {
                Console.Write("pick a street use this last number in the street [example: for the first street (1/2/3) type 3, etc.]");
                choice = Console.ReadLine();
                c = chkParse(choice);
                int[] street = new int[3];
                for (int i = 0; i < street.Length - 1; i++)
                {
                    street[i] = c - i;
                }
                arrChoice(street);
            }
            else if (input == 8)
            {
                Console.Write("Please type your first number hit enter and then type your second number");
                int[] split = new int[2];
                choice = Console.ReadLine();
                split[0] = chkParse(choice);
                choice = Console.ReadLine();
                split[1] = chkParse(choice);
                if (split[0] != (split[1] - 1) && split[0] != (split[1] + 1) && split[0] != (split[1] + 3) && split[0] != (split[1] - 3))
                    badInput();
                arrChoice(split);
            }
            else if (input == 9)
            {
                Console.Write("Please pick the top left number of a corner. [example: if you want (1/2/4/5) type 1");
                choice = Console.ReadLine();
                c = chkParse(choice);
                if ((c % 3) == 0)
                {
                    Console.WriteLine("Please pick the top left number of the corner");
                    Nav();
                }
                int[] corner = new int[4];
                corner[0] = c;
                for (int i = 1; i < corner.Length; i++)
                {
                    if (i > 1)
                        corner[i] = c + 1 + i;
                    else
                        corner[i] = c + i;
                }
                arrChoice(corner);
            }
        }

        private static void arrChoice(int[] A)
        {
            /*
            int len = A.Length;
            Position pos = new Position();
            if (len == 3)
                
            if (len == 2)

            if (len == 4)
            */
        }

        private static void strChoice(string choice, char A = 'A')
        {
            int numCols = 3;
            int colSize = 12;
            int setting = 0;
            Dictionary<string, List<int>> table = new Dictionary<string, List<int>>(numCols);
            Position pos = new Position();
            if (A == 'C')
            {
                for (Column cols = Column.First; cols <= Column.Third; cols++)
                {
                    setting++;
                    List<int> nums = new List<int>(colSize);
                    if (setting == 1)
                    {
                        for (int i = 1; i <= colSize; i += 3)
                            nums.Add(i);
                    }
                    if (setting == 2)
                    {
                        for (int i = 2; i <= colSize; i += 3)
                            nums.Add(i);
                    }
                    if (setting == 3)
                    {
                        for (int i = 3; i <= colSize; i += 3)
                            nums.Add(i);
                    }
                    table.Add(cols.ToString(), nums);
                }
                if (table[choice].Contains(pos.num))
                {
                    Console.WriteLine($"The number was {pos.num} {pos.color}");
                    Console.WriteLine("You WIN!");
                    Console.ReadKey();
                    Nav();
                }
                else
                {
                    Console.WriteLine("You lost");
                    Console.ReadKey();
                    Nav();
                }
            }
            if (A == 'D')
            {
                for (Column cols = Column.First; cols <= Column.Third; cols++)
                {
                    setting++;
                    List<int> nums = new List<int>(colSize);
                    for (int i = 1; i <= colSize; i++)
                    {
                        if (setting == 1)
                            nums.Add(i);
                        if (setting == 2)
                            nums.Add(i + 12);
                        if (setting == 3)
                            nums.Add(i + 24);
                    }
                    table.Add(cols.ToString(), nums);
                }
                if (table[choice].Contains(pos.num))
                {
                    Console.WriteLine($"The number was {pos.num} {pos.color}");
                    Console.WriteLine("You WIN!");
                    Console.ReadKey();
                    Nav();
                }
                else
                {
                    Console.WriteLine("You lost");
                    Console.ReadKey();
                    Nav();
                }
            }
            if (A == 'A')
            {

            }
        }

        private static void letterChoice(string choice, string L1, string L2)
        {
            if (choice == L1)
                strChoice(L1);
            if (choice == L2)
                strChoice(L2);
            else
                badInput();
        }
        private static void badInput()
        {
            Console.WriteLine("Invalid. returning to main menu");
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
        private static void ThreeOptions(string choice, char A)
        {
            int c = chkParse(choice);
            if (c < 1 || c > 3)
                badInput();
            if (c == 1)
                strChoice("First", A);
            else if (c == 2)
                strChoice("Second", A);
            else if (c == 3)
                strChoice("Third", A);
            else
                badInput();
        }
    }
}
