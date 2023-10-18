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
            return applePoison[0] == snake[0][0] && applePoison[1] == snake[0][1];
            //
        }
    }
}
