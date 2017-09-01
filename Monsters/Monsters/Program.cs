using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = { {'x','x','x','x','x','x','x','x','x','x'},
                {'x','x','x','x','x','x','x','x','x','x'},{'x','x','x','x','x','x','x','x','x','x'} };

            Game game = new Game(Display.GetWidth()-1, Display.GetHeight()-1);

            game.Update();
            game.Render();

            Console.ReadKey();
        }
    }
}
