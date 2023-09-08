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
            y = 5;
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
            Console.MoveBufferArea(x++, y, PLANE_WIDTH, PLANE_HEIGHT, x, y);

            if (x >= Config.SCREEN_WIDTH - PLANE_WIDTH)
            {
                for (int i = 0, z = PLANE_WIDTH, l = 0, p = 1; i < PLANE_WIDTH; i++)
                {
                    Console.MoveBufferArea(PLANE_WIDTH - 1, y, 1, PLANE_HEIGHT, l, y);

                    Console.MoveBufferArea(0, y, p++, PLANE_HEIGHT, 1, y);

                    Console.MoveBufferArea(x++, y, z--, PLANE_HEIGHT, x, y);

                    Thread.Sleep(40);
                }
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

        public void dropParachutist()
        {
            if (parachutists.Count == 0) { return; }
            Para parachutist = parachutists.First();
            parachutist.x = x;
            parachutist.altitude = this.y;
        }
    }
}
