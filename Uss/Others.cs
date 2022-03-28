using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Uss
{
	class Others
	{
		public void WriteGameOver(int a) // После прерывания работы программы выдает рамку с Game Over!  
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
			WriteName("Sisestage teie nimi: ", xOffset, yOffset++);
			name = Console.ReadLine();
			WriteText("Score: " + a, xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			if (a > 0)
			{
				StreamWriter to_file = new StreamWriter(@"..\..\Score.txt", true);
				to_file.WriteLine(name + " --> " + a);
				to_file.Close();
			}
		}

		public void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
		public void Score(int b)
		{
			Console.ForegroundColor = ConsoleColor.White;
			int xOffset = 60;
			int yOffset = 0;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("Score: " + b, xOffset + 10, yOffset++);
			yOffset++;
			WriteText("============================", xOffset, yOffset++);
		}
		public void WriteName(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.Write(text);
		}
	}
}
