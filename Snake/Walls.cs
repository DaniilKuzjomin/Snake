using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls
	{
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeight) // Конструктор для понятия габаритов карты
		{
			wallList = new List<Figure>();

			// Отрисовка рамки ( рисует линии по габаритам )
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

			// Добавление данных линий
			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
		}

		internal bool IsHit(Figure figure) // Функция для проверки соприкосновение змейки со стеной
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure)) // Если столкнулась, то возвращается True
				{
					return true;
				}
			}
			return false; // В другом случае, возвращаем False
		}

		// Метод отрисовки 
		public void Draw()
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}
}
