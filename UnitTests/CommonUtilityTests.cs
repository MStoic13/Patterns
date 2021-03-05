using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CommonUtilityTests
    {
        [TestMethod]
        public void RemoveAllWhitespaces_EmptyInput_EmptyOutput()
        {
            string input = string.Empty;
            string expectedOutput = string.Empty;
            string output = Utility.RemoveAllWhitespaces(input);
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void RemoveAllWhitespaces_WhitespaceInput_EmptyOutput()
        {
            string input = "";
            string expectedOutput = string.Empty;
            string output = Utility.RemoveAllWhitespaces(input);
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void RemoveAllWhitespaces_NonEmptyInput_NoWhitespacesOutput()
        {
            string input = "  can  I haz  ur chizburger  nao";
            string expectedOutput = "canIhazurchizburgernao";
            string output = Utility.RemoveAllWhitespaces(input);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
