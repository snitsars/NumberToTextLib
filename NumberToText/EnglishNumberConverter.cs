using Demo.NumberToText.Common;
using Demo.NumberToText.Interfaces;
using Demo.NumberToText.Models;

namespace Demo.NumberToText
{

    public class EnglishNumberConverter: INumberConverter
    {
        readonly EnglishNumberDictionary names = new EnglishNumberDictionary();

        private string GetNumberName(Number number)
        {
           
            var result = "";
            if (number.Hundred > 0)
            {
                result += names.Name(number.Hundred) + " " + names.GetNumberSizeName(100);
            }

            if ((number.Ten > 0 || number.One > 0) && result.Length > 0)
                result += " ";

            if (number.Ten == 1 && number.One < 3)
            {
                var numberValue = number.Hundred * 100 + number.Ten * 10 + number.One;
                result = names.Name(numberValue);
            }

            if (number.Ten == 1 && number.One > 2)
            {
                result = names.CorrectedNameIfExist(number.One) + names.Ending("3-10");
            }

            if (number.Ten > 1 && number.One > 0)
            {
                if (number.Ten > 3 && number.Ten < 5)
                {
                    result += names.CorrectedNameIfExist(number.Ten * 10) + names.Ending("20-90") + " " + names.Name(number.One);
                }
                else
                {
                    result += names.CorrectedNameIfExist(number.Ten) + names.Ending("20-90") + " " + names.Name(number.One);
                }
            }

            if (number.Ten > 1 && number.One == 0)
            {
                if (number.Ten > 3 && number.Ten < 5)
                {
                    result += names.CorrectedNameIfExist(number.Ten * 10) + names.Ending("20-90");
                }
                else
                {
                    result += names.CorrectedNameIfExist(number.Ten) + names.Ending("20-90");
                }
            }

            if (number.Hundred == 0 && number.Ten == 0)
            {
                result += names.Name(number.One);
            }

            return result;
        }
        public string Convert(decimal incomingValue)
        {
            string result = "";
            var numberParts = Number.GetInstance((int)incomingValue);
            result = GetNumberName(numberParts);

            return result;
        }


    }
}