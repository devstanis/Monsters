using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    static class Display
    {
        public static void ShowArray(char[,] arr)
        {
            Console.Clear();
            Console.CursorVisible = false;
            for(int i = 0; i < arr.GetLength(0); i++)
                for(int j = 0; j< arr.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(arr[i,j]);
                }
        }

        public static int GetWidth()
        {
            return Console.WindowWidth;
        }

        public static int GetHeight()
        {
            return Console.WindowHeight;
        }
    }
}
