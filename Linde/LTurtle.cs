using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Linde
{
    internal static class LTurtle
    {
        // in the future mb add custom ActionType and search it in rules[j].CustomActionType
        // remove length from config and add it to rule
        internal static List<LStep> GenerateSteps(StringBuilder sentence,List<LRule> rules,LConfig config)
        {
            Stack<LStep> savedSteps = new Stack<LStep>();
            
            LStep step = new LStep(config);
            List<LStep> steps = new List<LStep>() { step };


            for(int i = 0; i < sentence.Length; i++)
            {
                for(int j = 0; j < rules.Count; j++)
                {
                    if (rules[j].Rule.Key.CompareTo(sentence[i]) == 0)
                    {
                        if (rules[j].RuleAction == ActionType.Draw)
                        {
                            // 
                            step.Draw();
                            steps.Add(step);
                            
                        }
                        else if (rules[j].RuleAction == ActionType.Turn)
                        {
                            step.Turn(rules[j].Angle);
                        }
                    }
                }
            }

            return steps;
        }
    }
}
