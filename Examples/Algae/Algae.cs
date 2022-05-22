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

        Stopwatch st = new Stopwatch();

        st.Start();
        Console.WriteLine(linde.GenerateSentence(2));
        st.Stop();
        Console.WriteLine($"Generating sentence  {st.ElapsedMilliseconds}");
        st.Restart();

        st.Start();
        Console.WriteLine(linde.GenerateSteps());
        st.Stop();
        Console.WriteLine($"Generating steps  {st.ElapsedMilliseconds}");


    }
}