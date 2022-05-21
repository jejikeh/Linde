using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Linde
{
    internal static class LTurtle
    {
        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="rules"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        internal static List<LStep> GenerateSteps(StringBuilder sentence,List<LRule> rules,LConfig config)
        {
            Stack<LStep> savedSteps = new Stack<LStep>(); // used to store saved steps

            // create current step and asign to it Length of first branch
            LStep step = new LStep(config,rules[0].Length);
            List<LStep> steps = new List<LStep>() { step };


            for(int i = 0; i < sentence.Length; i++)
            {
                for(int j = 0; j < rules.Count; j++)
                {
                    if (rules[j].Rule.Key.CompareTo(sentence[i]) == 0)
                    {

                        if(rules[j].RuleAction == LAction.Save)
                        {
                            savedSteps.Push(step);
                        }
                        else if (rules[j].RuleAction == LAction.Load)
                        {
                            step = savedSteps.Pop();
                        }
                        else 
                        {
                            Func<LStep, float, LStep> act = rules[j].RuleAction;
                            step = act(step, rules[j].Angle);
                            if (rules[j].SaveStep)
                            {
                                steps.Add(step); // add to array
                            }
                        }
                    }
                }
            }
            return steps;
        }
    }
}
