using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutiste01
{
    internal class Plane
    {
        public int x;
        public int y;
        public const int PLANE_HEIGHT = 6;
        public const int PLANE_WIDTH = 26;

        private List<Para> parachutists;

        public Plane()
        {
            x = 0;
            y = 0;
            parachutists = new List<Para>();
        }
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
            Console.SetCursorPosition(x++, y);

            if (x >= Config.SCREEN_WIDTH - 1)
            {

                x = 0;
            }

        }

        public void draw()
        {
            for (int z = 0; z < view.Length; z++)
            {
                Console.SetCursorPosition(x, y + z);
                Console.Write(view[z]);
            }
        }

        public void onboarding(Para para)
        {
            this.parachutists.Add(para);
        }

        public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        public void dropParachutist()
        {
            if (parachutists.Count == 0) { return; }
            Para parachutist = parachutists.First();
            parachutist.x = x;
            parachutist.altitude = this.y;
            parachutist.isInAPlane = false;
        }
    }
}
