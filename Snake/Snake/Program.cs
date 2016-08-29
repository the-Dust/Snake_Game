using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            int x = numList[0];

            numList.RemoveAt(0);


            foreach (int i in numList)
            {
                Console.Write(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadKey();
        }
    }
}
