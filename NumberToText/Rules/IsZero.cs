using Demo.NumberToText.Interfaces;

namespace Demo.NumberToText.CommonRules
{
    public class IsZero: IBoolRule
    {
        public bool Check(decimal number)
        {
            return number == 0;
        }
    }
}
