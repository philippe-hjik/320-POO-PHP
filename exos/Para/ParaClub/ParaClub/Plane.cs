using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParaClub;

namespace ParaClub
{
    class Plane
    {
        public int PlaneX;
        public int PlaneY;
        public int ParaX;
        public int ParaY = 10;

        public int DropParaX;
        public int DropParaY;

        public int z = Config.SCREEN_WIDTH;
        

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
        
        public void dropParachutist()
        {
            Console.SetCursorPosition(ParaX, ParaY);
            for (int x = 0, y = 0; y < withoutParachute.Length; y++)
            {
                Console.SetCursorPosition(PlaneX, ParaY++);
                Console.Write(withoutParachute[y]);
            }
        }

        private string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
     };

        private string[] withParachute =
{
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
     };
    }
}
