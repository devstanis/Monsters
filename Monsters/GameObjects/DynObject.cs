using System;
using System.Drawing;

namespace Monsters.GameObjects
{
    abstract class DynObject:BaseObject
    {
        protected Point dir;
        public abstract void Update();

    }
}
