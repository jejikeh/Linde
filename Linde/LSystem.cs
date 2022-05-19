using System.Text;

namespace Linde
{
    public class LSystem
    {

        // TODO : 
        private LConfig m_config = new LConfig();




        /// <summary>
        /// Setup a LSystem class instance
        /// </summary>
        /// <param name="config">Config for generation</param>
        /// <param name="rules">All List of rules for generation</param>
        public LSystem(LConfig config)
        {
            m_config = config;
        }


        // Generate full sentence
        public StringBuilder GenerateSentence(int iterations)
        {
            StringBuilder generatedString = new StringBuilder(m_config.Axiom);

            for (int i = 0; i < iterations; i++)
            {
                // Decide how many threads use

                if (i < iterations / 4)
                {
                    generatedString = LSentenceBuilder.GenerateSentenceOneThread(generatedString, m_config.Rules);
                }
                else if (i < iterations / 2)
                {
                    generatedString = LSentenceBuilder.GenerateSentenceTwoThreads(generatedString, m_config.Rules);
                }
                else
                {
                    generatedString = LSentenceBuilder.GenerateSentenceFourThreads(generatedString, m_config.Rules);
                }
            }

            return generatedString;
        }
    }
}
