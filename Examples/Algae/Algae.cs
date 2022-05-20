using System.Numerics;
using Linde;
class Algae
{
    private static void Main()
    {
        // Setup the rules
        List<LRule> rules = new List<LRule>()
        {
            new LRule(
                'A',
                new List<string>(){"AB"},
                ActionType.Draw
            ),

            new LRule(
                'B',
                new List<string>(){"A"},
                ActionType.Turn,
                29f
            ),
        };

        // Setup config
        LConfig config = new LConfig(
            axiom: "A",
            rules: rules,
            length: 1,
            startDirection : new Vector2(0,1),
            startPosition : new Vector2(0,0)
        );

        // Class instance
        LSystem linde = new LSystem(config);

        linde.GenerateSentence(3);
        
        foreach(LStep step in linde.GenerateSteps())
        {
            Console.WriteLine(step.Position);
        }
        

    }
}