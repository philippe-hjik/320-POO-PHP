using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    class Plane
    {
        private int PlaneX;
        private int PlaneY;
        private int PlaneWidth = 27;
        private int PlaneHeight = 6;

        public string[] view =
        {
                @" _                         ",
                @"| \                        ",
                @"|  \       ______          ",
                @"--- \_____/  |_|_\____  |  ",
                @"  \_______ --------- __>-} ",
                @"        \_____|_____/   |  "
        };

        public void update()
        {
            if(Config.SCREEN_WIDTH - PlaneWidth > PlaneX)
                Console.MoveBufferArea(PlaneX++, PlaneY, PlaneWidth, PlaneHeight, PlaneX, PlaneY);
            else
                Console.MoveBufferArea(PlaneX++, PlaneY, PlaneWidth--, PlaneHeight, PlaneX, PlaneY);
        }






        public void draw()
    {
        for (int x = 0, y = 0; y < view.Length; y++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(view[y]);
        }
    }
}
}
