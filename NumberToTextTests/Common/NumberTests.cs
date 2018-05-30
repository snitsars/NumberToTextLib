using NUnit.Framework;

namespace Demo.NumberToText.Common.Tests
{
    [TestFixture()]
    public class NumberTests
    {
        [Test()]
        public void When_InputValueHasHundreds_Expected_HundredCounted()
        {
            var input = 400;
            var numberParams = Number.GetInstance(input);
            Assert.That(numberParams.Hundred, Is.EqualTo(4));
        }

        [Test()]
        public void When_InputValueHasTens_Expected_TensCounted()
        {
            var input = 50;
            var numberParams = Number.GetInstance(input);
            Assert.That(numberParams.Ten, Is.EqualTo(5));
        }

        [Test()]
        public void When_InputValue3Digits_Expected_OnesCounted()
        {
            var input = 8;
            var numberParams = Number.GetInstance(input);
            Assert.That(numberParams.One, Is.EqualTo(8));
        }

        [Test()]
        public void When_InputValueHasAllParts_Expected_CountedAllPArts()
        {
            var input = 987;
            var numberParams = Number.GetInstance(input);
            Assert.That(numberParams.Hundred, Is.EqualTo(9));
            Assert.That(numberParams.Ten, Is.EqualTo(8));
            Assert.That(numberParams.One, Is.EqualTo(7));
        }

        [Test()]
        public void When_InputValueIs0_Expected_0()
        {
            var input = 0;
            var numberParams = Number.GetInstance(input);
            Assert.That(numberParams.Hundred, Is.EqualTo(0));
            Assert.That(numberParams.Ten, Is.EqualTo(0));
            Assert.That(numberParams.One, Is.EqualTo(0));
        }

    }
}