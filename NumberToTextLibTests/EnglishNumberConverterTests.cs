using System.Runtime.Remoting;
using Demo.NumberToText;
using NUnit.Framework;

namespace Demo.NumberToTextLibTests
{
    [TestFixture]
    public class TestClass
    {
        private EnglishNumberConverter converter = new EnglishNumberConverter();
        [Test]
        public void When_InputValueEqualTo_1_Expected_One_Dollar()
        {
            string result = converter.Convert(1);
            Assert.That(result, Is.EqualTo("One dollar"));
        }
        public void When_InputValueEqualTo_2_Expected_Two_Dollars()
        {
            string result = converter.Convert(1);
            Assert.That(result, Is.EqualTo("Two dollars"));
        }
    }
}
