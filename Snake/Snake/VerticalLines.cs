using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLines : Figure
    {
        public VerticalLines(int x, int yHigh, int yLow, char sym)
        {
            for (int y = yHigh; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
         }
    }
}
