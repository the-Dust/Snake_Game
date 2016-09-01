using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 26);
            Console.SetWindowSize(80, 26);

            //Отрисовка стен
            Walls wall = new Walls(80, 26);
            wall.Draw();


            //Отрисовка змеи
            Point p1 = new Point(4,5,'*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            
            
            FoodCreator foodcreator = new FoodCreator(80,26,'$');
            Point food = foodcreator.CreateFood(snake.pList);
            food.Draw();
            
            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood(snake.pList);
                    food.Draw();
                }
                else
                {
                    Thread.Sleep(100);
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
                Thread.Sleep(20);
            }
            Console.SetCursorPosition(36,12);
            Console.Write("GAME OVER");
            Console.ReadLine();
            
            
        }
    }
}
