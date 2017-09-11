using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    abstract class Monster
    {
        protected Game field;
        protected Graphics g;
        protected Point pos;
        protected Point dir;
        protected Size size;
        protected Color color;

        public Monster(Game game, Graphics _g, Point _pos, Point _dir, Size _size, Color col)
        {
            field = game;
            g = _g;
            pos = _pos;
            dir = _dir;
            size = _size;
            color = col;
        }

        public virtual void Draw()
        {
            g.FillEllipse(Brushes.Cyan, new Rectangle(pos.X, pos.Y, size.Width, size.Height));
        }
    }
}
