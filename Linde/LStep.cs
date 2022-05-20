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
        public float Length;
        public Vector2 Position,Direction;

        public LStep(LConfig config)
        {
            Length = config.Length;
            Position = config.StartPosition;
            Direction = config.StartDirection;
        }
        public LStep(float length, Vector2 position,Vector2 direction)
        {
            Length = length;
            Position = position;
            Direction = direction;
        }

        internal void Draw()
        {
            Position += Direction * Length;
        }

        internal void Turn(float angle)
        {
            Direction = new Vector2(MathF.Cos(angle) * Position.X - MathF.Sin(angle) * Position.Y, MathF.Sin(angle) * Position.X + MathF.Cos(angle) * Position.Y);
            
        }
    }
}
