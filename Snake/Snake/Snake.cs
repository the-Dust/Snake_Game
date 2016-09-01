using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        int score = 0;
        
        public Snake(Point tail, int length, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear(tail);
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void Handle(ConsoleKey key)
        {
            
                if (key == ConsoleKey.LeftArrow)
                    direction = Direction.LEFT;
                else if (key == ConsoleKey.RightArrow)
                    direction = Direction.RIGHT;
                if (key == ConsoleKey.DownArrow)
                    direction = Direction.DOWN;
                if (key == ConsoleKey.UpArrow)
                    direction = Direction.UP;
            
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                Console.SetCursorPosition(0, 25);
                score++;
                Console.Write("Score = {0}", score);
                return true;
            }
            else 
                return false;
        }

        internal bool IsHitTail()
        {
            Point head = GetNextPoint();
            foreach (var p in pList)
            {
                if (head.IsHit(p))
                { return true; }

            }
            return false;
        }
    }
}
