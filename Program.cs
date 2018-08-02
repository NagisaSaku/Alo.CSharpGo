using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            SortSnake snake = new SortSnake();
            var result = snake.SortSnakes(10);
            snake.PrintSnake(result,10);
            Console.ReadLine();
        }
    }
}
