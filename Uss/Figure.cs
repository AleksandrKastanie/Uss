using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
	class Figure
	{
		protected List<Point> pList; // Создаем список точек для рамки

		public void Draw() // Метод дров перебирает каждую точку р из списка рЛист
		{
			foreach (Point p in pList) // перебор точек 
			{
				p.Draw(); // рисует точки 
			}
		}

		internal bool IsHit(Figure figure)//Передаём в качестве аргумента переменную 
		{
			foreach (var p in pList)
			{
				if (figure.IsHit(p)) //Если фигура касается с точкой из списка возвращается "true"
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)// Метод для сравнения пересечения кординат точек
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
