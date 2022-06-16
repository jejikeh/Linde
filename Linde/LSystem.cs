using Linde.GenString;
using Linde.GenSteps;
using System.Text;

namespace Linde
{
    public class LSystem
    {

        // TODO : 
        internal LConfig config = new LConfig();
        internal StringBuilder generatedString;
        private int m_iteration_generated = 0;

        /// <summary>
        /// Setup a LSystem class instance
        /// </summary>
        /// <param name="config">Config for generation</param>
        public LSystem(LConfig config)
        {
            generatedString = new StringBuilder(config.Axiom);
            this.config = config;
        }

        public StringBuilder GenerateSentence(int iterations)
        {
            for(int i = m_iteration_generated; i < iterations; i++)
            {
                generatedString = LStringBuilder.GenerateSentenceOneThread(this);
            }
            m_iteration_generated = iterations;
            return generatedString;
        }
    }
}
