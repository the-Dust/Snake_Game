﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
