using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    interface Imd
    {
        void Update();
        void Render();
    }

    interface ImdM : Imd
    {
        void Move();
    }
}
