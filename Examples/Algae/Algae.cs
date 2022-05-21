using System.Numerics;
using Linde;
class Algae
{
    public static LStep Die(LStep step, float angle)
    {
        step.Position.X += 100;
        return step;
    }
    private static void Main()
    {
        // Setup the rules
        List<LRule> rules = new List<LRule>()
        {
            new LRule(
                ifSeeThatChar : 'F',
                pasteThatStrings :new List<string>(){"FF"},
                ruleAction : LAction.Draw,
                saveStep : true
                ),
            new LRule(
                ifSeeThatChar : 'X',
                pasteThatStrings : new List<string>(){"F-[[X]+X]+F[+FX]-X"},
                ruleAction : LAction.Turn,
                angle : 30
                ),
            new LRule(
                ifSeeThatChar : '[',
                pasteThatStrings : new List<string>(){""},
                ruleAction : LAction.Save
                ),
            new LRule(
                ifSeeThatChar : ']',
                pasteThatStrings : new List<string>(){""},
                ruleAction : Die
                ),
        };

        // Setup config
        LConfig config = new LConfig(
            axiom: "X",
            rules: rules,
            startDirection : new Vector2(0,1),
            startPosition : new Vector2(0,0)
        );

        // Class instance
        LSystem linde = new LSystem(config);
        


        Console.WriteLine(linde.GenerateSentence(1));
        
        foreach(LStep step in linde.GenerateSteps())
        {
            Console.WriteLine(step.Position);
        }
        

    }
}