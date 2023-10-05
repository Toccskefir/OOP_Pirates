using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pirates
{
    internal class Captain : Pirate
    {
        public Captain(string name) : base(name)
        {
            base.IntoxicateLevel = 0;
            base.Alive = true;
        }
    }
}
