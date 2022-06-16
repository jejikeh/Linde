using System.Text;

namespace Linde.GenString
{
    internal static class LStringBuilder
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
        private static StringBuilder GenerateNextStep(char c, LSystem lsystem)
        {
            bool wasFound = false;
            for (int i = 0; i < lsystem.config.Rules.Count; i++)
            {
                if (lsystem.config.Rules[i].Rule.Key.CompareTo(c) == 0)
                {
                    wasFound = true;
                    return lsystem.config.Rules[i].Rule.Value.ElementAt(m_random.Next(lsystem.config.Rules[i].Rule.Value.Count));
                }
            }
            // If character was not found in sentence
            if (!wasFound)
            {
                return new StringBuilder(c.ToString());
            }
            return new StringBuilder("");

        }


        /// just default for loop
        internal static StringBuilder GenerateSentenceOneThread(LSystem lsystem)
        {
            // generatedSentence - result string
            StringBuilder generatedSentence = new StringBuilder();

            // wow this loop 
            for (int j = 0; j < lsystem.generatedString.Length; j++)
            {
                generatedSentence.Append(GenerateNextStep(lsystem.generatedString[j], lsystem));
            }
            // append all generated sentences
            return generatedSentence;
        }
    }
}
