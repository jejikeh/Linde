using System.Numerics;
namespace Linde
{
    public struct LConfig
    {
        /// <summary>
        /// Used to setup config in LSystem constructor
        /// </summary>
        internal string Axiom;
        internal List<LRule> Rules;
        internal Vector2 StartPosition, StartDirection;

        /// <summary>
        /// Config for generating L-System generation
        /// </summary>
        /// <param name="Axiom">Started sentence</param>
        /// <param name="Rules">Defined rules</param>
        /// <param name="Length">Length of each branch</param>
        public LConfig(string axiom, List<LRule> rules, Vector2 startDirection,Vector2 startPosition)
        {
            Axiom = axiom;
            Rules = rules;
            StartDirection = startDirection;
            StartPosition = startPosition;
        }

    }
}
