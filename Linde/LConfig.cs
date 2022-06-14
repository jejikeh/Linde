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

        /// <summary>
        /// Config for generating L-System generation
        /// </summary>
        /// <param name="axiom">Started sentence</param>
        /// <param name="rules">Defined rules</param>
        public LConfig(string axiom, List<LRule> rules)
        {
            Axiom = axiom;
            Rules = rules;
        }

    }
}
