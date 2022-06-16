using System.Numerics;
using System.Linq;
namespace Linde
{
    /// <summary>
    /// Predefined methods for L-System generation
    /// </summary>
    /// 
    public static class LAction
    {
        
        /// <summary>
        /// Draw branch forward
        /// </summary>
        /// <param name="step"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static LStep Draw(LStep step,float angle)
        {
            //step.Position += step.Direction * step.Length;
            return step;
        }
        /// <summary>
        /// Turn point of step
        /// </summary>
        /// <param name="step"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static LStep Turn(LStep step,float angle)
        {
            //step.Direction = new Vector2(MathF.Cos(2) * step.Position.X - MathF.Sin(2) * step.Position.Y, MathF.Sin(2) * step.Position.X + MathF.Cos(2) * step.Position.Y);
            return step;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="step"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static LStep Save(LStep step,float angle)
        {
            return step;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="step"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static LStep Load(LStep step, float angle)
        {
            return step;
        }
        
    }
}
