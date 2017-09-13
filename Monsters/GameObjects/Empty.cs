using System.Drawing;

namespace Monsters.GameObjects
{
    class Empty:StateObject
    {
        public Empty(Graphics _g, Point _pos, Size _size)
        {
            g = _g;
            pos = _pos;
            size = _size; 
        }
        public override void Draw()
        {
            g.FillEllipse(Brushes.Black, new Rectangle(pos.X, pos.Y, size.Width, size.Height));
        }
    }
}
