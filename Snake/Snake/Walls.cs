using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wList;
        public Walls(int borderWidth, int borderHeight)
        {
            wList = new List<Figure>();
            HorizontalLines upLine = new HorizontalLines(0, borderWidth-2, 0, '+');
            HorizontalLines downLine = new HorizontalLines(0, borderWidth - 2, borderHeight-2, '+');
            VerticalLines leftLine = new VerticalLines(0, 0, borderHeight - 2, '+');
            VerticalLines rightLine = new VerticalLines(borderWidth - 2, 0, borderHeight - 2, '+');
            wList.Add(upLine);
            wList.Add(downLine);
            wList.Add(leftLine);
            wList.Add(rightLine);
        }

        internal bool IsHit(Figure f)
        { 
            foreach (var wall in wList)
            {
                if (wall.IsHit(f))
                { return true; }

            }
            return false;
        }

        internal void Draw()
        {
            foreach (var f in wList)
            {
                f.Draw();
            }
        }
    }
}
