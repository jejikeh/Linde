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
        internal ActionType RuleAction;
        internal float Angle;
        /// <summary>
        /// Rule object that holds what do if see that char
        /// </summary>
        /// <param name="ifSeeThatString"></param>
        /// <param name="pasteThatString"></param>
        /// <param name="step"></param>
        public LRule(char ifSeeThatChar, List<string> pasteThatStrings, ActionType step)
        {
            Rule = new KeyValuePair<char, List<string>>(ifSeeThatChar, pasteThatStrings);
            RuleAction = step;
            Angle = float.NaN;
        }

        public LRule(char ifSeeThatChar, List<string> pasteThatStrings, ActionType step,float angle)
        {
            Rule = new KeyValuePair<char, List<string>>(ifSeeThatChar, pasteThatStrings);
            RuleAction = step;
            Angle = angle;
        }
    }
}
