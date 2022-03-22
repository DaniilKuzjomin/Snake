using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Snake
{
    class GameOver : Score
    {
        public void Game_Over() // Вывод окна конца игры
        {
            Console.Clear(); // Очистка консоли
            Console.ForegroundColor = ConsoleColor.Red; // Изменение цвета на красный
            Walls walls = new Walls(80, 25); // Создание новых стен
            walls.Draw(); // Отрисовка стен на поле

            int xOffset = 25;
            int yOffset = 10;
            Console.ForegroundColor = ConsoleColor.Red; // Установка цвета окна конца игра на красный
            Console.SetCursorPosition(xOffset, yOffset++);
            Text.WriteText("==============================", xOffset, yOffset++); // Вывод окна в консоль с координатами
            Text.WriteText("Game Over", xOffset + 11, yOffset++); // Вывод окна в консоль с координатами
            yOffset++;

            Console.ForegroundColor = ConsoleColor.Red; // Установка цвета окна конца игра на красный
            Text.WriteText("Your score is - " + playerScore, xOffset + 8, yOffset++); // Вывод окна в консоль с координатами

            Console.ForegroundColor = ConsoleColor.Red; // Установка цвета окна конца игра на красный
            Text.WriteText("==============================", xOffset, yOffset++); // Вывод окна в консоль с координатами
            yOffset++;
        }
    }
}
