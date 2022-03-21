using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
	class HorizontalLine : Figure // Чтобы не прописовать методы дров и т.д. делаем наследие из класса Фигура 
	{
		public HorizontalLine(int xLeft, int xRight, int y, char sym) //  Конструктор предназначен для постраения горизонтальной линии
		{
			pList = new List<Point>(); // создаем список точек (горизонтальная линия) 
			for (int x = xLeft; x <= xRight; x++) // создам цикл фор для создания точного кол-ва точек
			{
				Point p = new Point(x, y, sym);// Задаем новую точку р с определенными параметрами, менятся будет только x
				pList.Add(p);// добавляем новую точку горизонт. линии в список pList
			}
		}
	}
}
