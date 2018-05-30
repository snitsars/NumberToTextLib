using Demo.NumberToText.Interfaces;
using Demo.NumberToText.Models;
using Demo.NumberToText.Rules;

namespace Demo.NumberToText
{
    public class UkraineNumberConverter : INumberConverter
    {
        readonly UkrainNumberNaming names = new UkrainNumberNaming();
        public string Convert(decimal incomingValue)
        {
            var result = "";
            var isNuberInZerroTenRange = new IsNumberLessEqualThanTen();
            if (isNuberInZerroTenRange.Check(incomingValue))
            {
                result = names.CorrectedNameIfExist((int)incomingValue);
            }
            return result;
        }
    }
}
