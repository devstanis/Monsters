using System;
using System.Drawing;
using System.Windows.Forms;

namespace Monsters
{
    static class Display
    {
        static BufferedGraphicsContext context;
        public static BufferedGraphics buffer;
        static public int Width { get; set; }
        static public int Height { get; set; }



        static public void Init(Form form)
        {
            Graphics g;
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.Width;
            Height = form.Height;
            Settings.SetSize(Width, Height);
            buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));
        }

        static public void Draw()
        {
            buffer.Graphics.Clear(Color.Black);
            buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(100, 100, 200, 200));
            buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(100, 100, 200, 200));
            buffer.Render();
        }
    }
}
