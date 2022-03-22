using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Speed
    {
        public static int Snake_Speed(int score)
        {
            int speed = 100; // Изначальная скорость змейки
            if (score > 5) // Если счёт больше 5, то скорость увеличивается на 15
            {
                speed = 85;
            }
            if (score > 15) // Если счёт больше 15, то скорость увеличивается на 30
            {
                speed = 70;
            }
            if (score > 20) // Если счёт больше 20, то скорость увеличивается на 40
            {
                speed = 60;
            }
            if (score > 35) // Если счёт больше 35, то скорость увеличивается на 50
            {
                speed = 50;
            }
            return speed;
        }
    }
}
