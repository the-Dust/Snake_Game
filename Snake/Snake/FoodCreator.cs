using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class FoodCreator : Figure
    {
        int mapWidth;
        int mapHeight;
        char sym;
        

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        
        public Point CreateFood(List<Point> p2)
        {
            Point p;
            Start:
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            p = new Point(x, y, sym);
            //Проверяем, не совпадают ли координаты еды с координатами змейки (все равно не помогает)
            foreach (Point point in p2)
            { 
                if (p.x == point.x && p.y == point.y)
                goto Start; 
            }
           // if (p2.Contains(p)) //Альтернативный способ проверки координат
            //Если все норм, создаем еду
            return p;
            
        }
    }
}
