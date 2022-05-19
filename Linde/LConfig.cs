namespace Linde
{
    public struct LConfig
    {
        /// <summary>
        /// Used to setup config in LSystem constructor
        /// </summary>
        internal string Axiom;
        internal List<LRule> Rules;
        internal int TurnAngle, Length;


        /// <summary>
        /// Config for generating L-System generation
        /// </summary>
        /// <param name="axiom">Started sentence</param>
        /// <param name="rules">Defined rules</param>
        /// <param name="turnAngle">Angle when turn</param>
        /// <param name="length">Length of each branch</param>
        public LConfig(string axiom, List<LRule> rules, int turnAngle, int length)
        {
            Axiom = axiom;
            Rules = rules;
            TurnAngle = turnAngle;
            Length = length;
        }

    }
}
