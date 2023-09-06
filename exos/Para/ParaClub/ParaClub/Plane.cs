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
        private int z = Config.SCREEN_WIDTH;
        

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
            Console.SetCursorPosition(PlaneX++, PlaneY);
        }

        public void draw()
        {
            if (PlaneX >= 149)
                PlaneX = 0;

            Console.SetCursorPosition(PlaneX++, PlaneY);
            for (int x = 0, y = 0; y < view.Length; y++)
            {
                Console.SetCursorPosition(PlaneX, y);
                Console.Write(view[y]);
            }
            
        }
    }
}
