using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    abstract class Monster : ImdM
    {
        char symbol;
        Field field;

        public int X { get; set; }
        public int Y { get; set; }

        public Monster(Field f, char c)
        {
            field = f;
            symbol = c;
        }
        
        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        // private
        public void Move()
        {
            throw new NotImplementedException();
        }

        private bool IsInField(int x, int y)
        {
            return x >= 0 && x <= field.SizeX - 1 && y >= 0 && y <= field.SizeX - 1;
        }       
    }
}
