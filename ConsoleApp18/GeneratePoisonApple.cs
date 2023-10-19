using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void GeneratePoisonApple()
        {
            // с помощью рандомайзера сгенерировать 2 числа в промежутке от 0 до 40, полученные числа домножить на 10
            // назначить полученные числа в координаты applePoison
            // нарисовать голубой круг размером 10 на 10 по новым координатам
            int schance = random.Next(1, 4);
            if (schance == 2)
            {
                for (int i = 0; i < 2; i++)
                    applePoison[i] = random.Next(0, 35);
                applePoison[0] *= 10;
                applePoison[1] *= 10;
                graphics.FillEllipse(System.Drawing.Brushes.Blue, apple[0], apple[1], 10, 10);
                if (applePoison[0] == apple[0] && applePoison[1] == apple[1])
                {
                    applePoison[0] += 10;
                    applePoison[0] += 20;
                }
            }
            applePoison[2] = 1;
        }

    }
}
