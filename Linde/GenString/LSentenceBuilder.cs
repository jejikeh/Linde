using System.Text;

namespace Linde.GenString
{
    internal static class LSentenceBuilder
    {
        private static Random m_random = new Random();

        // TODO
        // [2] Re-Archetecture code 

        /// <summary>
        /// Generate random sentence 
        /// </summary>
        /// <param name="sentence">Base sentence</param>
        /// <param name="rules">Rules for gen sentences</param>
        /// <returns></returns>
        /// 

        // Generate next step based on charracter given and rules
        // a -> ab
        private static StringBuilder GenerateNextStep(char c, List<LRule> rules)
        {
            bool wasFound = false;
            for (int i = 0; i < rules.Count; i++)
            {
                if (rules[i].Rule.Key.CompareTo(c) == 0)
                {
                    wasFound = true;
                    return new StringBuilder(rules[i].Rule.Value.ElementAt(m_random.Next(rules[i].Rule.Value.Count)));
                }
            }
            // If character was not found in sentence
            if (!wasFound)
            {
                return new StringBuilder(c);
            }

            return new StringBuilder();

        }

        /// just default for loop
        internal static StringBuilder GenerateSentenceOneThread(LSystem lsystem, int limitIteration, int currentIteration = 0)
        {

            if (currentIteration >= limitIteration)
            {
                return lsystem.generatedString;
            }

            // generatedSentence - result string
            StringBuilder newGeneratedString = new StringBuilder();

            // wow this loop 
            for (int c = 0; c < lsystem.generatedString.Length; c++)
            {
                newGeneratedString.Append(lsystem.generatedString[c]);
                for(int r = 0; r < lsystem.config.Rules.Count; r++)
                {
                    if (lsystem.config.Rules[r].Rule.Key.CompareTo(lsystem.generatedString[c]) == 0)
                    {
                        newGeneratedString.Append(lsystem.config.Rules[r].Rule.Value.ElementAt(m_random.Next(lsystem.config.Rules[r].Rule.Value.Count)));
                    }
                }
            }
            // append all generated sentences
            return generatedSentence;


            
        }
    }
}
