using NUnit.Framework;

namespace Demo.NumberToText.Tests
{
    [TestFixture()]
    public class EnglishNumberConverterTests
    {
        [Test()]
        public void When_InputValue1_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(1);
            Assert.That(result, Is.EqualTo("one"));
        }

        [Test()]
        public void When_InputValue2_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(2);
            Assert.That(result, Is.EqualTo("two"));
        }

        [Test()]
        public void When_InputValue3_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(3);
            Assert.That(result, Is.EqualTo("three"));
        }

        [Test()]
        public void When_InputValue4_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(4);
            Assert.That(result, Is.EqualTo("four"));
        }

        [Test()]
        public void When_InputValue5_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(5);
            Assert.That(result, Is.EqualTo("five"));
        }

        [Test()]
        public void When_InputValue6_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(6);
            Assert.That(result, Is.EqualTo("six"));
        }

        [Test()]
        public void When_InputValue7_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(7);
            Assert.That(result, Is.EqualTo("seven"));
        }

        [Test()]
        public void When_InputValue8_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(8);
            Assert.That(result, Is.EqualTo("eight"));
        }

        [Test()]
        public void When_InputValue9_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(9);
            Assert.That(result, Is.EqualTo("nine"));
        }

        [Test()]
        public void When_InputValue0_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(0);
            Assert.That(result, Is.EqualTo("zero"));
        }

        [Test()]
        public void When_InputValue10_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(10);
            Assert.That(result, Is.EqualTo("ten"));
        }

        [Test()]
        public void When_InputValue11_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(11);
            Assert.That(result, Is.EqualTo("eleven"));
        }

        [Test()]
        public void When_InputValue12_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(12);
            Assert.That(result, Is.EqualTo("twelve"));
        }

        [Test()]
        public void When_InputValue13_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(13);
            Assert.That(result, Is.EqualTo("thirteen"));
        }

        [Test()]
        public void When_InputValue14_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(14);
            Assert.That(result, Is.EqualTo("fourteen"));
        }

        [Test()]
        public void When_InputValue24_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(24);
            Assert.That(result, Is.EqualTo("twenty four"));
        }

        [Test()]
        public void When_InputValue40_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(40);
            Assert.That(result, Is.EqualTo("forty"));
        }

        [Test()]
        public void When_InputValue45_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(45);
            Assert.That(result, Is.EqualTo("forty five"));
        }

        [Test()]
        public void When_InputValue55_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(55);
            Assert.That(result, Is.EqualTo("fifty five"));
        }

        [Test()]
        public void When_InputValue68_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(68);
            Assert.That(result, Is.EqualTo("sixty eight"));
        }

        [Test()]
        public void When_InputValue78_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(78);
            Assert.That(result, Is.EqualTo("seventy eight"));
        }

        [Test()]
        public void When_InputValue83_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(83);
            Assert.That(result, Is.EqualTo("eighty three"));
        }

        [Test()]
        public void When_InputValue95_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(95);
            Assert.That(result, Is.EqualTo("ninety five"));
        }

        [Test()]
        public void When_InputValue99_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(99);
            Assert.That(result, Is.EqualTo("ninety nine"));
        }

        [Test()]
        public void When_InputValue159_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(159);
            Assert.That(result, Is.EqualTo("one hundred fifty nine"));
        }

        [Test()]
        public void When_InputValue999_ExpectedRightValue()
        {
            var converter = new EnglishNumberConverter();
            var result = converter.Convert(999);
            Assert.That(result, Is.EqualTo("nine hundred ninety nine"));
        }
    }
}
 