using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.SetBufferSize(250, 80); // Установка размера окна

			// Отрисовка стен
			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*'); // Создание точки
			Snake snake = new Snake(p, 4, Direction.RIGHT); // Создание изначальной змейки ( состоящей из 4 точек )
			snake.Draw(); // Отрисовка созданной змейки на поле

			// Создание еды
			FoodCreator foodCreator = new FoodCreator(80, 25, '$'); // Создание еды в заданных пределах
			Point food = foodCreator.CreateFood(); // Вызов метода и создание точки еды
			food.Draw(); // Отрисовка еды на поле

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail()) // Если змейка коснётся стенки или хвоста то игра заканчивается
				{
					break;
				}
				if (snake.Eat(food)) // Если змейка коснётся точки еды то появляется новая еда в новой точке
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else // Движение змейки
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable) // Проверка нажатия клавиши
				{
					ConsoleKeyInfo key = Console.ReadKey(); // Получает информацию о нажатой клавише
					snake.HandleKey(key.Key); // Вызов проверки нажатия клавиши
				}
			}
			Console.ReadLine();
	}
}
