using Demo.NumberToText.Interfaces;

namespace Demo.NumberToText.Rules
{
    class IsNumberLessEqualThanTen : IBoolRule
    {
        public bool Check(decimal number)
        {
            return number >= 0 && number < 11;
        }
    }
}
