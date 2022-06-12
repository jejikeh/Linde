using System.Text;

namespace Linde.GenSentence
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
        internal static StringBuilder GenerateSentenceOneThread(StringBuilder sentence, List<LRule> rules)
        {
            // generatedSentence - result string
            StringBuilder generatedSentence = new StringBuilder();

            // wow this loop 
            for (int j = 0; j < sentence.Length; j++)
            {
                generatedSentence.Append(GenerateNextStep(sentence[j], rules));
            }
            // append all generated sentences
            return generatedSentence;
        }
    }
}
