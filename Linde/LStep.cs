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
        internal Vector2 Direction;
        public Vector2 Position;

        public LStep(LConfig config, float length)
        {
            Length = length;
            Position = config.StartPosition;
            Direction = config.StartDirection;
        }
    }
}
