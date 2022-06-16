using System.Text;
using System.Diagnostics;
using Linde;

class Algae
{
    public static LStep Die(LStep step, float angle)
    {
        //step.Position.X += 100;
        return step;
    }


    private static void Main()
    {
        // Setup the rules
        List<LRule> rules = new List<LRule>()
            {
                new LRule(
                    a: '1',
                    b : new List<StringBuilder>(){new StringBuilder("11")},
                    LAction.Draw),
                new LRule(
                    a : '0',
                    b : new List<StringBuilder>(){new StringBuilder("1[0]0")},
                    LAction.Draw),
            };

        // Setup config
        LConfig config = new LConfig(
            axiom: "0",
            rules: rules
        );

        // Class instance
        LSystem linde = new LSystem(config);
        Stopwatch st = new Stopwatch();

        st.Start();
        Console.WriteLine(linde.GenerateSentence(2));
        st.Stop();
        Console.WriteLine($"Taked {st.ElapsedMilliseconds} ms");
    }
}