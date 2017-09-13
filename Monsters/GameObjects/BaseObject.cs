using System.Drawing;

namespace Monsters
{
    abstract class BaseObject
    {
        protected Graphics g;
        protected Point pos;
        protected Size size;

        public virtual void Draw()
        {
            g.FillEllipse(Brushes.Cyan, new Rectangle(pos.X, pos.Y, size.Width, size.Height));
        }
    }
}
