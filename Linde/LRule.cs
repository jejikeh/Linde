namespace Linde
{
    /*
     * LSRule Class
     */

    // Rule struct, used to define rules.
    public struct LRule
    {
        // using field direct for optimization
        internal KeyValuePair<char, List<string>> rule;
        //internal Tuple<char, List<string>> GetRule { get { return rule; } }
        public LRule(char a, List<string> b)
        {
            rule = new KeyValuePair<char, List<string>>(a, b);
        }
    }
}
