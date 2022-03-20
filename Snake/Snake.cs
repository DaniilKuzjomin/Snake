using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure
	{
		Direction direction; // Хранение данных класса направления

		public Snake(Point tail, int length, Direction _direction) // Конструктор задающий стартовую точку появления и задающий направление у змейки на поле 
		{
			direction = _direction; // Переменная направления 
			pList = new List<Point>(); // Список точек из которых состоит змейка
			for (int i = 0; i < length; i++) // Цикл для создания копии хвостовой точки
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}

		public void Move() // Конструктор для движения змейки
		{
			Point tail = pList.First(); 
			pList.Remove(tail); // Удаление точки хвоста для передвижения
			Point head = GetNextPoint(); // Добавление точки для движения змейки
			pList.Add(head); // Добавление точки в список

			tail.Clear(); // Уберает последнюю точку с хвоста
			head.Draw(); // Отрисовка новой точки перед головой змейки
		}

		public Point GetNextPoint() // Функция для вычисления движения змейки
		{
			Point head = pList.Last(); // Позиция главной точки до перемещения
			Point nextPoint = new Point(head); // Создание новой точки которая будет являтся главной точкой
			nextPoint.Move(1, direction); // Движение точки по направлению
			return nextPoint; // Возврат переменной
		}

		public bool IsHitTail() // Проверка столкнулась ли змейка со своих хвостом
		{
			var head = pList.Last(); // Получение координат главной ( 1ой ) точки
			for (int i = 0; i < pList.Count - 2; i++) // Проверка на совпадение координат главной точки и хвоста
			{
				if (head.IsHit(pList[i])) // Если есть пересечение
					return true; // Возвращаем True
			}
			return false; // В других случаях возвращаем False
		}

		// Метод проверяющий реакцию на нажатие клавиш.
		public void HandleKey(ConsoleKey key)
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

		public bool Eat(Point food) // Метод поедания еды
		{
			Point head = GetNextPoint(); // Передвижение змейки
			if (head.IsHit(food)) // Если координаты змейки и еды совпадают то добавляется новая еда на поле
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
