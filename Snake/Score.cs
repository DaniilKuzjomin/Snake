using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Snake
{
    class Score
    {
        public static int playerScore;
        public void Score_Increase()
        {
            playerScore++;
            Text.WriteText("Очки: " + playerScore, 81, 12); // Вывод окна очков справа от поля по координатам

            if (playerScore < 10) // Условие если счёт меньше 10, то цвет синий
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (playerScore < 20) // Условие если счёт больше 20, то цвет меняется на зеленый
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (playerScore < 30) // Условие если счёт больше 30, то цвет меняется на желтый
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (playerScore < 40) // Условие если счёт больше 40, то цвет меняется на желтый
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (playerScore < 50) // Условие если счёт больше 50, то цвет меняется на желтый
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }


        public void Save(int playerScore) // Сохранение результата в текстовый файл
        {
            string text;
            StreamWriter use = new StreamWriter(@"..\..\Result.txt", true);
            text = playerScore + " ";
            use.WriteLine(text);
            use.Close();
        }
    }
}