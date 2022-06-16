using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Linde
{
    public struct LStep
    {
        internal float Length;

        public LStep(LConfig config, float length)
        {
            Length = length;
        }
    }
}
