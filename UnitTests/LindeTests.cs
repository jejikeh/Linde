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
                    a: 'A',
                    b : new List<StringBuilder>(){new StringBuilder("AB")},
                    LAction.Draw),
                new LRule(
                    a : 'B',
                    b : new List<StringBuilder>(){new StringBuilder("A")},
                    LAction.Draw),
            };

            LConfig config = new(axiom: "A", rules: rules);

            LSystem linde = new LSystem(config);


            for(int i = 0; i < expectedOutputs.Count; i++)
            {
                StringBuilder generated = linde.GenerateSentence(i);
                Assert.AreEqual(expectedOutputs[i].ToString(), generated.ToString(),"Sentence do not generated correctly!");
            }
        }
    }
}