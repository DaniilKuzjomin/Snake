using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
		// Поля ( данные относящиеся к точке на экране )
		public int x;
		public int y;
		public char sym;

		// Конструктора позволяющие создавать экземпляры точек
		public Point()
		{
		}

		public Point(int x, int y, char sym) // Конструктор вызова функции для создания точек
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p) // Конструктор для создание точки за счёт другой точки
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}


		// Функция позволяющая перевести точку
		public void Move(int offset, Direction direction)
		{
			if (direction == Direction.RIGHT)
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p) // Метод для проверки есть ли пересечение по координатам текущей точки и точки заданного аргумента  
		{
			return p.x == this.x && p.y == this.y;
		}

		// Функция позволяющая отрисовать точку
		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		public void Clear() // Метод для того что бы стереть последнюю точку с экрана
		{
			sym = ' ';
			Draw();
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
