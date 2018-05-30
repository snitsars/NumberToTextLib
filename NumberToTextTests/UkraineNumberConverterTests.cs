using NUnit.Framework;
using Demo.NumberToText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.NumberToText.Tests
{
    [TestFixture()]
    public class UkraineNumberConverterTests
    {
        [Test(), Sequential]
        public void When_InputValueFromZeroToTen_Expected_RelativeName(
            [Values(1,2,3,4,5,6,7,8,9,0,10)] int inNumber, 
            [Values("одна", "дві", "три", "чотири", "п'ять", "шість", "сім", "вісім", "дев'ять", "нуль", "десять")] string expected)
        {
            var converter = new UkraineNumberConverter();
            var result = converter.Convert(inNumber);
            Assert.That(result, Is.EqualTo(expected));
        }        

        [Test()]
        public void When_InputValue40_ExpectedRightValue()
        {
            var converter = new UkraineNumberConverter();
            var result = converter.Convert(40);
            Assert.That(result, Is.EqualTo("сорок"));
        }

        [Test()]
        public void When_InputValue41_ExpectedRightValue()
        {
            var converter = new UkraineNumberConverter();
            var result = converter.Convert(41);
            Assert.That(result, Is.EqualTo("сорок одна"));
        }

        [Test()]
        public void When_InputValue42_ExpectedRightValue()
        {
            var converter = new UkraineNumberConverter();
            var result = converter.Convert(42);
            Assert.That(result, Is.EqualTo("сорок дві"));
        }

        [Test()]
        public void When_InputValue45_ExpectedRightValue()
        {
            var converter = new UkraineNumberConverter();
            var result = converter.Convert(45);
            Assert.That(result, Is.EqualTo("сорок три"));
        }
    }
}