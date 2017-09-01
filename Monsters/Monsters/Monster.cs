using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    abstract class Monster : IMonster
    {
        Game field;

        public char Symbol { get; }
        public int X { get; set; }
        public int Y { get; set; }

        public Monster(Game f, char c)
        {
            field = f;
            Symbol = c;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        // private
        private bool IsInField(int x, int y)
        {
            return x >= 0 && x <= field.SizeX - 1 && y >= 0 && y <= field.SizeX - 1;
        }       
    }
}
