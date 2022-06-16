using Linde.GenSentence;
using Linde.GenSteps;
using System.Text;

namespace Linde
{
    public class LSystem
    {

        // TODO : 
        internal LConfig config = new LConfig();
        internal StringBuilder generatedString;

        /// <summary>
        /// Setup a LSystem class instance
        /// </summary>
        /// <param name="config">Config for generation</param>
        public LSystem(LConfig config)
        {
            generatedString = new StringBuilder(config.Axiom);
            this.config = config;
        }


        /// <summary>
        /// Generate sentence based on the config ( rules, axiom )
        /// </summary>
        /// <param name="iterations"> number of recursive calls</param>
        /// <returns></returns>
        public StringBuilder GenerateSentence(int iterations = 0)
        {
            
        }
    }
}
