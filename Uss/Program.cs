using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            HorizontalLine rightline = new HorizontalLine(0,118,0,'+');
            VerticalLine upLine = new VerticalLine(0, 29, 0, '+');
            HorizontalLine leftline = new HorizontalLine(0, 118, 29, '+');
            VerticalLine downLine = new VerticalLine(0, 29, 118, '+');
            rightline.Draw();
            upLine.Draw();
            leftline.Draw();
            downLine.Draw();

            Point p = new Point(10, 7, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(120, 30, '¤');
            Point food = foodCreator.CreateFood();
            food.Draw();



            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine ();    
        }

        
    }
}
