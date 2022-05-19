using Linde;
class Algae
{
    private static void Main()
    {
        // Setup the rules
        List<LRule> rules = new List<LRule>()
        {
            new LRule('A',new List<string>(){"AB"}),
            new LRule('B',new List<string>(){"A"}),
        };

        // Setup config
        LConfig config = new LConfig(
            axiom: "A",
            rules: rules,
            length: 1,
            turnAngle: 2
        );

        // Class instance
        LSystem linde = new LSystem(config);


        Console.WriteLine(linde.GenerateSentence(20));

    }
}