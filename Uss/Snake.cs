using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
	class Snake : Figure //Класс "Snake" является наследником класса "Figure" так как тоже по сути образует фигуру из точек
	{
		Direction direction;// Хранит данные о направлении куда должна двигаться змейка а заполнятются они вот тут

		public Snake(Point tail, int length, Direction _direction)//Конструктор змейка принимает три аргумента - положения точки хвоста, длинну и направления куда змейка начнёт своё движение
		{
			direction = _direction;//Приравниваем переменную к данным direction 
			pList = new List<Point>();// Создает список точек, т.к. список точек это наша змейка
			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}

		public void Move()// Метод движения Змейки
		{
			Point tail = pList.First();// Первая точка списка (хвост)
			pList.Remove(tail);// Удалят первый индекс списка  
			Point head = GetNextPoint();// добавляет новую точку = голова
			pList.Add(head);// добавляет новую точку в список

			tail.Clear();// Удаляет точку с экрана 
			head.Draw();
		}

		public Point GetNextPoint() // Метод, добавляющий новую точку в конец списка 
		{
			Point head = pList.Last();// прирааниваем точку (Голову змеи) к последнему индексу списка
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);
			return nextPoint;
		}

		public bool IsHitTail()// Метод для нормальной змейки, при столкновении с хвостом прерывает работу программы 
		{
			var head = pList.Last();
			for (int i = 0; i < pList.Count - 2; i++)
			{
				if (head.IsHit(pList[i]))
					return true;
			}
			return false;
		}

		public void HandleKey(ConsoleKey key) // Метод для назначения направления змейки через клавиши стрелок
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
		}

		public bool Eat(Point food) // Метод, который будет добавлять змейке еще одну точку при столкновении с едой (Назначенным символом)
		{
			Point head = GetNextPoint();
			if (head.IsHit(food))
			{
				food.sym = head.sym;
				pList.Add(food);
				return true;
			}
			else
				return false;
		}
	}
}
