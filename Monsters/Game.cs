using System;
using System.Collections.Generic;
using System.Drawing;
using Monsters.GameObjects;

namespace Monsters
{
    class Game
    {
        List<BaseObject> gList;
        BufferedGraphics buffer;
        Graphics g;
        public int SizeX { get; private set; }
        public int SizeY { get; private set; }

        public Game(BufferedGraphics b)
        {
            buffer = b;
            g = b.Graphics;
            gList = new List<BaseObject>();
            LoadMap();
        }

        public void Draw()
        {
            foreach (BaseObject bo in gList)
                bo.Draw();
            buffer.Render();
        }

        public void Update()
        {
            foreach (BaseObject bo in gList)
            {
                if (bo is DynObject) (bo as DynObject).Update();
            }
        }

        private void LoadMap()
        {
            SizeX = Settings.cntX;
            SizeY = Settings.cntY;
            LoadWalsAndEmpty();
            LoadTrees();
            LoadMonsters();
        }

        private void LoadTrees()
        {

        }

        private void LoadWalsAndEmpty()
        {
            for (int y = 0; y < SizeY; y++)
                for (int x = 0; x < SizeX; x++)
                    if (Settings.wallArr[x, y] == 1)
                        gList.Add(new Wall(new Point(x, y), 
                            new Size(Settings.sizeX, Settings.sizeY)));
                    else gList.Add(new Empty(new Point(x, y),
                            new Size(Settings.sizeX, Settings.sizeY)));
        }

        private void LoadMonsters()
        {

        }
    }
}
