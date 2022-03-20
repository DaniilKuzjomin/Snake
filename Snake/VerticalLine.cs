using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figure
	{
		public VerticalLine(int yUp, int yDown, int x, char sym) // Конструктор для создания линий поля
		{
			pList = new List<Point>(); // Список точек
			for (int y = yUp; y <= yDown; y++) // Создание верт. точек
			{
				Point p = new Point(x, y, sym); // Создание точек с координатами
				pList.Add(p); // Добавление их в список
			}
		}
	}
}
