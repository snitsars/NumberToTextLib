using System.Collections.Generic;

namespace Demo.NumberToText.Models
{
    public class UkrainNumberNaming
    {

        private readonly Dictionary<int, string> name = new Dictionary<int, string>()
        {
            {0, "нуль" },
            {1, "один" },
            {2, "два" },
            {3, "три" },
            {4, "чотири" },
            {5, "п'ять" },
            {6, "шість" },
            {7, "сім" },
            {8, "вісім" },
            {9, "дев'ять" },
            {10, "десять" }
        };

        private readonly Dictionary<int, string> exceptionals = new Dictionary<int, string>()
        {
            { 1, "одна" },
            { 2, "дві" },
            { 40, "сорок" }
            
        };

        private readonly Dictionary<string, string> ending = new Dictionary<string, string>()
        {

            {"3-10", "надцять" },            
            {"20-90", "ty" }
        };

        private readonly Dictionary<long, string> numberSizeNamme = new Dictionary<long, string>()
        {
            {100, "hundred"},
            {1000, "thousand"},
            {1000000, "million"},
            {1000000000, "Billion"},
            {1000000000000, "Trillion"}

        };


        /// <summary>
        public string Name(int numberValue)
        {
            if (name.ContainsKey(numberValue))
                return name[numberValue];

            return "";
        }

        public string CorrectedNameIfExist(int numberValue)
        {
            var result = Name(numberValue);

            if (exceptionals.ContainsKey(numberValue))
                result = exceptionals[numberValue];

            return result;
        }

        public string Ending(string rangeName)
        {
            if (ending.ContainsKey(rangeName))
                return ending[rangeName];

            return "";
        }

        public string GetNumberSizeName(long number)
        {
            var result = "";
            if (numberSizeNamme.ContainsKey(number))
                result = numberSizeNamme[number];
            return result;
        }

    }
}