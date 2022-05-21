namespace Linde
{
    /*
     * LSRule Class
     */

    // Rule struct, used to define rules.
    public struct LRule
    {

        // using field direct for optimization
        internal KeyValuePair<char, List<string>> Rule;

        // Method of rule
        internal Func<LStep,float,LStep> RuleAction;

        internal float Angle;
        internal bool SaveStep;
        internal float Length;
        /// <summary>
        /// Rule object that holds parameters of generation
        /// </summary>
        /// <param name="ifSeeThatChar">if see that chad</param>
        /// <param name="pasteThatStrings">paste thats strings based on random</param>
        /// <param name="ruleAction">call static method</param>
        /// <param name="angle">wich angle to turn</param>
        /// <param name="length">length of step</param>
        

        public LRule(char ifSeeThatChar, List<string> pasteThatStrings, Func<LStep,float,LStep> ruleAction, float angle = 0,bool saveStep = false,float length = 1)
        {
            Rule = new KeyValuePair<char, List<string>>(ifSeeThatChar, pasteThatStrings);
            RuleAction = ruleAction;
            Angle = angle;
            SaveStep = saveStep;
            Length = length;
        }
    }
}
