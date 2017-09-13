using System;
using System.Drawing;

namespace Monsters.GameObjects
{
    class Wall:StateObject
    {
        public Wall(Point _pos, Size _size)
        {
            pos = _pos;
            size = _size;
        }
        public override void Draw()
        {
            g.FillEllipse(Brushes.Yellow, new Rectangle(pos.X, pos.Y, size.Width, size.Height));
        }
    }
}
