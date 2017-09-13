using System;
using System.Drawing;

namespace Monsters.GameObjects
{
    class Dog:DynObject
    {
        public Dog(Point _pos, Point _dir, Size _size)
        {
            pos = _pos;
            dir = _dir;
            size = _size;
        }
        public override void Draw()
        {
            g.FillEllipse(Brushes.Blue, new Rectangle(pos.X, pos.Y, size.Width, size.Height));
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
