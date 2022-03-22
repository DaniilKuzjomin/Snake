using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Text
    {
        public static void WriteText(String text, int xOffset, int yOffset) // Вывод текста в консоль
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
