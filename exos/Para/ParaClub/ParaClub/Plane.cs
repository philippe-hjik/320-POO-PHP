using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    class Plane
    {

        public void update()
        {
            
        }
        public void draw()
        {
            for (int x = 0, y = 0; y < view.Length; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(view[y]);
            }
        }
        private string[] view =
        {
                @" _                         ",
                @"| \                        ",
                @"|  \       ______          ",
                @"--- \_____/  |_|_\____  |  ",
                @"  \_______ --------- __>-} ",
                @"        \_____|_____/   |  "
        };

    }

}
