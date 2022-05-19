using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Linde
{
    internal static class LSentenceBuilder
    {
        private static Random m_random = new Random();

        // TODO
        // [2] Re-Archetecture code 

        /// <summary>
        /// Generate random sentence 
        /// </summary>
        /// <param name="sentence">Base sentence ( axiom )</param>
        /// <param name="rules">Rules for gen sentences</param>
        /// <returns></returns>
        /// 

        // Generate next step based on charracter given and rules
        // a -> ab
        private static string GenerateNextStep(char c, List<LRule> rules)
        {
            bool wasFound = false;
            for (int i = 0; i < rules.Count; i++)
            {
                if (rules[i].rule.Key.CompareTo(c) == 0)
                {
                    wasFound = true;
                    return rules[i].rule.Value.ElementAt(m_random.Next(rules[i].rule.Value.Count));
                }
            }
            // If character was not found in sentence
            if (!wasFound)
            {
                return c.ToString();
            }

            return new string("");

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

        // Copy paste code :(
        // Two threds string generation. String cut on 2 parts
        internal static StringBuilder GenerateSentenceTwoThreads(StringBuilder sentence, List<LRule> rules)
        {
            // generatedSentence - result string
            StringBuilder generatedSentence = new StringBuilder();

            // 4 threads - 4 sentence
            StringBuilder firstHalfSentence = new StringBuilder();
            StringBuilder secondHalfSentence = new StringBuilder();

            // bad bad badb adb dvode voed ecode
            Thread firstIterate = new Thread(() =>
            {
                for (int j = 0; j < sentence.Length / 2; j++)
                {
                    firstHalfSentence.Append(GenerateNextStep(sentence[j], rules));
                }
            });
            Thread secondIterate = new Thread(() =>
            {
                for (int j = sentence.Length / 2; j < sentence.Length; j++)
                {
                    secondHalfSentence.Append(GenerateNextStep(sentence[j], rules));
                }
            });

            firstIterate.Start();
            secondIterate.Start();

            // wait until all threads stopped
            firstIterate.Join();
            secondIterate.Join();

            generatedSentence.Append(firstHalfSentence).Append(secondHalfSentence);
            // append all generated sentences
            return generatedSentence;
        }

        // 4 threads string generation. string cut on 4 parts
        internal static StringBuilder GenerateSentenceFourThreads(StringBuilder sentence, List<LRule> rules)
        {
            // generatedSentence - result 
            StringBuilder generatedSentence = new StringBuilder();
            // 4 threads - 4 sentence
            StringBuilder firstHalfSentence = new StringBuilder();
            StringBuilder secondHalfSentence = new StringBuilder();
            StringBuilder thirdHalfSentence = new StringBuilder();
            StringBuilder fourHalfSentence = new StringBuilder();



            // when i see this i wanna die 
            Thread firstIterate = new Thread(() =>
            {
                for (int j = 0; j < sentence.Length / 4; j++)
                {
                    firstHalfSentence.Append(GenerateNextStep(sentence[j], rules));
                }
            });
            Thread secondIterate = new Thread(() =>
            {
                for (int j = sentence.Length / 4; j < sentence.Length / 2; j++)
                {
                    secondHalfSentence.Append(GenerateNextStep(sentence[j], rules));
                }
            });
            Thread thirdIterate = new Thread(() =>
            {
                for (int j = sentence.Length / 2; j < sentence.Length * 3 / 4; j++)
                {
                    thirdHalfSentence.Append(GenerateNextStep(sentence[j], rules));
                }
            });
            Thread fourIterate = new Thread(() =>
            {
                for (int j = (sentence.Length * 3) / 4; j < sentence.Length; j++)
                {
                    fourHalfSentence.Append(GenerateNextStep(sentence[j], rules));
                }
            });



            firstIterate.Start();
            secondIterate.Start();
            thirdIterate.Start();
            fourIterate.Start();

            // wait until all threads stopped
            firstIterate.Join();
            secondIterate.Join();
            thirdIterate.Join();
            fourIterate.Join();

            generatedSentence.Append(firstHalfSentence).Append(secondHalfSentence).Append(thirdHalfSentence).Append(fourHalfSentence);
            // append all generated sentences
            return generatedSentence;
        }

    }
}
