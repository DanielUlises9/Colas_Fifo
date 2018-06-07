using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Fifo
{
    class RandomGenerator
    {
        Random r = new Random(DateTime.Now.Second);

        public int elrandom()
        {
            return r.Next(4,15);
        }
    }
}
