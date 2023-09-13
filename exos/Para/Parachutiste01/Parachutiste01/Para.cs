using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutiste01
{
    internal class Para
    {
        private const int PARA_HEIGHT = 6;
        private const int PARA_WIDTH = 6;

        public string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
     };

        public string[] withParachute =
{
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
     };

        public string name;
        public int x;
        public int altitude;
        public bool parachuteIsOpen;
        public bool isInAPlane;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Para(string name)
        {
            this.name = name;
        }
        public void drawPara()
        {
            string[] view = parachuteIsOpen ? withParachute : withoutParachute;

            if (!this.isInAPlane)
            {
                for (int i = 0; i < view.Length; i++)
                {
                    Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.altitude + i);
                    Console.Write(view[i]);
                }
            }
        }

        public void updatePara()
        {
            if (!isInAPlane) // Il a sauté
            {
                if (altitude > PARA_HEIGHT) // il est en l'air
                {
                    if (parachuteIsOpen)
                    {
                        altitude -= 1; // il tombe lentement
                    }
                    else
                    {
                        altitude -= 3; // il tombe vite
                    }
                    // Décision d'ouvrir le parachute
                    if (altitude < Config.SCREEN_HEIGHT / 2)
                    {
                        parachuteIsOpen = true;
                    }
                }
                else // il est au sol
                {
                    parachuteIsOpen = false;
                }
            }
        }
    }
}
