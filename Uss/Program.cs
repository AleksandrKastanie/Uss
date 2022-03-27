using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Uss
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)


			{
				int score = 0; 
				Console.ForegroundColor = ConsoleColor.Green;
				Menu menu = new Menu();
				menu.MainMenu();
				Walls walls = new Walls(50, 30); // Создает стены для змейки по размерам рамки (меньше значения не работают) 
				walls.Draw();


				Point p = new Point(4, 5, '*');
				Snake snake = new Snake(p, 4, Direction.RIGHT);//При запуске игры змейка начинает движение вправо из указаной точки
				snake.Draw();

				FoodCreator foodCreator = new FoodCreator(50,30, '$'); //Создание объекта еда с условиями длина,ширина карты и символ как еда будет выглядеть
				Point food = foodCreator.CreateFood();
				food.Draw();

				while (true)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					if (walls.IsHit(snake) || snake.IsHitTail())//если змея врезается в стенку или хвост то программа прерывается
					{
						break;
					}
					if (snake.Eat(food))
					{
						score++;
						food = foodCreator.CreateFood();
						food.Draw();
					}
					else
					{
						snake.Move();
					}

					if (Console.KeyAvailable)
					{
						ConsoleKeyInfo key = Console.ReadKey();
						snake.HandleKey(key.Key);
					}
                    if (score <10)
                    {
						Thread.Sleep(100);//Задержка 100 милисекунд, можно поставить значения и меньше 
					}
					else if (score>10 && score<25)
                    {
						Thread.Sleep(75);
					}
                    else
                    {
						Thread.Sleep(50);
					}
					Score(score);
				}
				Clear();
				WriteGameOver(score);
				Console.ReadLine();
			}
		}


		static void WriteGameOver(int a) // После прерывания работы программы выдает рамку с Game Over! и автором проекта 
		{
			int xOffset = 5;
			int yOffset = 8;
			string name;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(xOffset, yOffset++);
			Walls walls = new Walls(50, 30); // Создает стены для змейки по размерам рамки (меньше значения не работают) 
			walls.Draw();
			WriteText("============================", xOffset, yOffset++);
			WriteText("GAME OVER!", xOffset + 10, yOffset++);
			yOffset++;
			WriteName("Sisestage teie nimi: ", xOffset , yOffset++);
			name = Console.ReadLine();
			WriteText("Score: " + a, xOffset , yOffset++);
			WriteText("============================", xOffset, yOffset++);
            if (a>0)
            {
				StreamWriter to_file = new StreamWriter(@"..\..\Score.txt", true);
				to_file.WriteLine(name + " --> " + a);
				to_file.Close();
			}
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
		static void Score(int b)
        {
			Console.ForegroundColor = ConsoleColor.White;
			int xOffset = 60;
			int yOffset = 0;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("Score: "+ b, xOffset + 10, yOffset++);
			yOffset++;
			WriteText("============================", xOffset, yOffset++);
		}
		static void WriteName(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.Write(text);
		}
	}
}
