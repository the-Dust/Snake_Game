using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLines
    {
        List<Point> pList;
        public VerticalLines(int x, int yHigh, int yLow, char sym)
        {
            pList = new List<Point>();
            for (int y = yHigh; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
         }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
