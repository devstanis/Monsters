using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    class Game
    {
        // private members
        private char[,] field;
        char borderSym;
        char emptySym;
        private List<Monster> listMonsers;

        public int SizeX { get; private set; }
        public int SizeY { get; private set; }
        
        public char this[int x, int y]
        {
            get { return field[x, y];}
            set { field[x, y] = value; }
        }

        public Game(int x, int y)
        {
            SizeX = x;
            SizeY = y;
            field = new char[x, y];
            listMonsers = new List<Monster>();
            emptySym = Settings.emptySym;
            borderSym = Settings.borderSym;
        }

        public void Update()
        {
            foreach (Monster m in listMonsers)
                m.Update();
            FillArray();
        }

        public void Render()
        {
            Display.ShowArray(field);
        }

        private void SetBorder()
        {
            for(int x = 0; x < SizeX; x++)
                for(int y = 0; y < SizeY; y++)
                {
                    if (x == 0 || y == 0 || x == SizeX - 1 || y == SizeY - 1)
                        field[x, y] = borderSym;
                    else field[x, y] = emptySym;
                }
        }

        private void FillArray()
        {
            SetBorder();
            foreach (Monster m in listMonsers)
                field[m.X, m.Y] = m.Symbol;
        }
    }
}
