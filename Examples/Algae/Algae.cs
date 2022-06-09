using System.Numerics;
using System.Diagnostics;
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
                ifSeeThatChar : 'A',
                pasteThatStrings :new List<string>(){"AB"},
                ruleAction : LAction.Draw,
                saveStep : true
                ),
            new LRule(
                ifSeeThatChar : 'B',
                pasteThatStrings : new List<string>(){"A"},
                ruleAction : LAction.Turn,
                angle : 30
                )
        };

        // Setup config
        LConfig config = new LConfig(
            axiom: "A",
            rules: rules,
            startDirection : new Vector2(0,1),
            startPosition : new Vector2(0,0)
        );

        // Class instance
        LSystem linde = new LSystem(config);



        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(linde.GenerateSentence(i));
        }



    }
}