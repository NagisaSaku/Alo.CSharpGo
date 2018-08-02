using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNumber
{
    public class SortSnake
    {
        public int[,] SortSnakes(int dimension)
        {
            int dimensionNumber = dimension * dimension;
            int[,] snakeMatrix = new int[dimension, dimension];

            int snakeNum = 1;//用于流水总数字
            int OneLineCount = 1;//用于记录第几圈的初始1

            while (snakeNum <= dimensionNumber)
            {
                // Dim 用来记录圈数
                for (int dim = dimension; dim >= 1; dim--)
                {
                    //X代表横轴，Y代表纵轴
                    
                    //1.矩形右边X = dimension 然后Y++
                    for (int rightY = OneLineCount; rightY <= dim; rightY++)
                    {
                        snakeMatrix[dim - 1 , rightY -1 ] = snakeNum;
                        //流水数组
                        snakeNum++;
                    }

                    //2.矩形下边Y = dimension 然后X--
                    for (int downX = dim - 1; downX >= OneLineCount; downX--)
                    {
                        snakeMatrix[downX -1 , dim - 1 ] = snakeNum;
                        //流水数组
                        snakeNum++;
                    }

                    //3.矩形左边X = LeftOneLineCount 然后Y--
                    for (int leftY = dim - 1; leftY >= OneLineCount; leftY--)
                    {
                        snakeMatrix[OneLineCount -1 , leftY -1 ] = snakeNum;//这里这个1要记录一个Count                        
                        //流水数组
                        snakeNum++;
                    }

                    //4.矩形上边Y = LeftOneLineCount 然后X++
                    for (int upX = OneLineCount + 1; upX <= dim -1 ; upX++)
                    {
                        snakeMatrix[upX -1 , OneLineCount - 1 ] = snakeNum;
                        //流水数组
                        snakeNum++;
                    }

                    OneLineCount++;//需要流水第一列计数
                }
            }
            

            return snakeMatrix;
        }

        public void PrintSnake(int[,] Snakes, int dimension)
        {           
            for (int x = 0; x <= dimension - 1; x++)
            {
                for (int y = 0; y <= dimension - 1; y++)
                {
                    Console.Write(Snakes[y,x] + ",");
                }
                Console.Write("\r\n");
            }
        }
    }
}
