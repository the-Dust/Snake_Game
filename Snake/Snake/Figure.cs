using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Figure
    {
        public List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure f)
        {
            foreach (var p in pList)
            {
                if (f.IsHit(p))
                { return true; }

            }
            return false;
        }

        internal bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (point.IsHit(p))
                { return true; }

            }
            return false;
        }
    }
}
