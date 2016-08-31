﻿using System;
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
            
            //Отрисовка рамки
            HorizontalLines upLine = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines downLine = new HorizontalLines(0, 78, 24, '+');
            VerticalLines leftLine = new VerticalLines(0, 0, 24, '+');
            VerticalLines rightLine = new VerticalLines(78, 0, 24, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка змеи
            Point p1 = new Point(4,5,'*');
            Snake snake = new Snake(p1, 10, Direction.RIGHT);
            snake.Draw();
            
            
            FoodCreator foodcreator = new FoodCreator(80,26,'$');
            Point food = foodcreator.CreateFood(snake.pList);
            food.Draw();
            
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood(snake.pList);
                    food.Draw();
                }
               /* else
                {
                    Thread.Sleep(100);
                    snake.Move();
                }*/

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
                Thread.Sleep(50);
                snake.Move();
                
            }
            
            
        }
    }
}
