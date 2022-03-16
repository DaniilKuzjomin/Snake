using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodCreator
	{
		// Поля
		int mapWidht;
		int mapHeight;
		char sym;


		// Создание рандомной переменной
		Random random = new Random();


		// Конструктор
		public FoodCreator(int mapWidth, int mapHeight, char sym)
		{
			this.mapWidht = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}


		// Метод создания еды на поле
		public Point CreateFood()
		{
			int x = random.Next(2, mapWidht - 2);
			int y = random.Next(2, mapHeight - 2);
			return new Point(x, y, sym);
		}
	}
}
