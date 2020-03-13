using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roulette
{
    class Position
    {
        public int num { get; set; }
        public string color { get; set; }
        int[] Reds = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        int[] Blacks = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

        public Position()
        {
            Random r = new Random();
            num = r.Next(-1, 36);
            if (Reds.Contains(num))
                color = "RED";
            else if (Blacks.Contains(num))
                color = "BLACK";
            else
            {
                if (num == -1)
                    num = 0;
                color = "green";
            }
        }
    }
}
