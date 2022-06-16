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
                new StringBuilder("ABAABABAABAAB"), // 5 iteration
                new StringBuilder("ABAABABAABAABABAABABA"), // 6 iteration
                new StringBuilder("ABAABABAABAABABAABABAABAABABAABAAB"), // 7 iteration

            };

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

        [TestMethod]
        public void FractalTreeMethod()
        {
            List<StringBuilder> expectedOutputs = new List<StringBuilder>()
            {
                new StringBuilder("0"), // 0 iteration
                new StringBuilder("1[0]0"), // 1 iteration
                new StringBuilder("11[1[0]0]1[0]0"), // 2 iteration
                new StringBuilder("1111[11[1[0]0]1[0]0]11[1[0]0]1[0]0"), // 3 iteration
            };

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

            LConfig config = new(axiom: "0", rules: rules);

            LSystem linde = new LSystem(config);


            for (int i = 0; i < expectedOutputs.Count; i++)
            {
                StringBuilder generated = linde.GenerateSentence(i);
                Assert.AreEqual(expectedOutputs[i].ToString(), generated.ToString(), "Sentence do not generated correctly!");
            }
        }

        [TestMethod]
        public void KochMethod()
        {
            List<StringBuilder> expectedOutputs = new List<StringBuilder>()
            {
                new StringBuilder("0"), // 0 iteration
                new StringBuilder("1[0]0"), // 1 iteration
                new StringBuilder("11[1[0]0]1[0]0"), // 2 iteration
                new StringBuilder("1111[11[1[0]0]1[0]0]11[1[0]0]1[0]0"), // 3 iteration
            };

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

            LConfig config = new(axiom: "0", rules: rules);

            LSystem linde = new LSystem(config);


            for (int i = 0; i < expectedOutputs.Count; i++)
            {
                StringBuilder generated = linde.GenerateSentence(i);
                Assert.AreEqual(expectedOutputs[i].ToString(), generated.ToString(), "Sentence do not generated correctly!");
            }
        }

    }
}