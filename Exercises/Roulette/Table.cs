using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Table
    {
        private const int numCols = 3;
        private const int colSize = 12;
        enum Column { First, Second, Third };
        public Dictionary<string, List<int>> table = new Dictionary<string, List<int>>(numCols);
        public Table this[Dictionary<string, List<int>>;]
        {
            get { return table; }
            set { Builder(); }
        }
        public void Builder()
        {
            int setting = 0;
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
        }
    }
}
