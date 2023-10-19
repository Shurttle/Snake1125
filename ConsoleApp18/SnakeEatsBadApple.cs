using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static bool SnakeEatsPoisonApple()
        {
            return Badaplle[0] == snake[0][0] && Badaplle[1] == snake[0][1] && Badaplle.Count() == 3;
            //проверка на ядовитость яблока
        }
    }
}
