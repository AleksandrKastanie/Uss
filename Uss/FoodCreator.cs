using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
	class FoodCreator // Класс для создания точек на карте, которые будут умещаться в заданном диапазоне 
	{
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random();

		public FoodCreator(int mapWidth, int mapHeight, char sym) // Конструктор для создания еды значения берутся из програм.кс
		{
			this.mapWidht = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		public Point CreateFood() // Метод создает точки в рамке, которые будут занимать 2 пиксиля и так же не будут заходить на само поле, т.к. отнимается от значения карты -2 
		{
			int x = random.Next(2, mapWidht - 2);
			int y = random.Next(2, mapHeight - 2);
			return new Point(x, y, sym);
		}
	}
}
