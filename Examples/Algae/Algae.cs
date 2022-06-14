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
                a: 'A',
                b: new List<string>(){"AB"},
                ruleAction: LAction.Draw,
                drawStep: true
                ),
            new LRule(
                a: 'B',
                b: new List<string>(){"A"},
                ruleAction: LAction.Turn,
                angle: 30
                )
        };

        // Setup config
        LConfig config = new LConfig(
            axiom: "A",
            rules: rules
        );

        // Class instance
        LSystem linde = new LSystem(config);



        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(linde.GenerateSentence(i));
        }

    }
}