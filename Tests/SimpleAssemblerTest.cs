using NUnit.Framework;
using Assembler;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class SimpleAssemblerTests
    {
        private void Test(Dictionary<string, int> expected, Dictionary<string, int> actual)
        {
            var expectedStr = "{ " +
                              string.Join(", ", expected.Select(kv => $"{kv.Key}: {kv.Value}"))
                              + " }";
            var actualStr = "{ " +
                            string.Join(", ", actual.Select(kv => $"{kv.Key}: {kv.Value}"))
                            + " }";

            Assert.AreEqual(expected, actual, $"Expected: {expectedStr}, Actual: {actualStr}");
        }

        [Test, Description("Should work for some example programs")]
        public void ExamplePrograms()
        {
            Test(new Dictionary<string, int> { { "a", 1 } },
                SimpleAssembler.Interpret(new[] { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a" }));
            Test(new Dictionary<string, int> { { "a", 0 }, { "b", -20 } },
                SimpleAssembler.Interpret(new[] { "mov a -10", "mov b a", "inc a", "dec b", "jnz a -2" }));
        }

        [Test, Description("Jnz com constante")]
          public void ConstantJnz()
        {
            Test(new Dictionary<string, int> { { "a", 0 }, { "b", -20 }, { "c", -2 }},
                SimpleAssembler.Interpret(new[] { "mov a -10", "mov b a", "mov c -2", "inc a", "dec b", "jnz a c" }));
        }

        // 
        [Test, Description("caso estranho")]
          public void ExtremeCase()
        {
            Test(new Dictionary<string, int> { { "ab", 5 }, { "bb", 5 } },
                SimpleAssembler.Interpret(new[] {"mov ab 5", "mov bb ab", "jnz cb 2", "dec ab", "jnz ab 15"}));
        }
    }
}
