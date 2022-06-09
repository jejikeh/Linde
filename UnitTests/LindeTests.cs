using Linde;

namespace UnitTests
{
    [TestClass]
    public class LindeTests
    {
        [TestMethod]
        public void AlgaeMethod()
        {
            List<StringBuilder> expectedOutputs = new List<StringBuilder>()
            {
                new StringBuilder("A"), // 0 iteration
                new StringBuilder("AB"), // 1 iteration
                new StringBuilder("ABA"), // 2 iteration
                new StringBuilder("ABAAB"), // 3 iteration
                new StringBuilder("ABAABABA"), // 4 iteration
            };
            StringBuilder axiom = new StringBuilder("");

            List<LRule> rules = new List<LRule>()
            {
                new LRule(
                    ifSeeThatChar : 'A',
                    pasteThatStrings : new List<string>(){"AB"},
                    LAction.Draw),
                new LRule(
                    ifSeeThatChar : 'B',
                    pasteThatStrings : new List<string>(){"A"},
                    LAction.Draw),
            };

            LConfig config = new LConfig(
                axiom : "A",
                rules : rules,
                startDirection : new Vector2(0,1),
                startPosition : new Vector2(0,0));

            LSystem linde = new LSystem(config);


            for(int i = 0; i < expectedOutputs.Count; i++)
            {
                StringBuilder generated = linde.GenerateSentence(i);
                Assert.AreEqual(expectedOutputs[i].ToString(), generated.ToString(),"Sentence do not generated correctly!");
            }
        }
    }
}