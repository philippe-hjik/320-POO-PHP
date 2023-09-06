using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParaClub;

namespace ParaClub
{
    internal class Para
    {
        string Name;
        static int nbPara;

        public Para(string name)
        {
            this.Name = name;
            nbPara++;
        }     
    }
}
