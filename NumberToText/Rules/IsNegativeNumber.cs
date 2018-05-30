using Demo.NumberToText.Interfaces;

namespace Demo.NumberToText.CommonRules
{
    class IsNegativeNumber: IBoolRule
    {
        public bool Check(decimal number)
        {
            return number < 0;
        }
    }
}
