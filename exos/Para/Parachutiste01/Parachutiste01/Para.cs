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
    }
}
