using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    class Field : Imd
    {
        public int SizeX { get; private set; }
        public int SizeY { get; private set; }

        public Field(int x, int y)
        {
            SizeX = x;
            SizeY = y;
        }
        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
