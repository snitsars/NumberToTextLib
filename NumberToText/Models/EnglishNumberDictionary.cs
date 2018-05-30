using System.Collections.Generic;

namespace Demo.NumberToText.Models
{
    public class EnglishNumberDictionary
    {
        private readonly Dictionary<int, string> name = new Dictionary<int, string>()
        {
            {0, "zero" },
            {1, "one" },
            {2, "two" },
            {3, "three" },
            {4, "four" },
            {5, "five" },
            {6, "six" },
            {7, "seven" },
            {8, "eight" },
            {9, "nine" },
            {10, "ten" },
            {11, "eleven" },
            {12, "twelve" },
        };

        private readonly Dictionary<int, string> exceptionals = new Dictionary<int, string>()
        {
            { 3, "thir" },
            { 8, "eigh" },
            { 5, "fif" },
            { 2, "twen" },
            { 40, "for" },
        };

        private readonly Dictionary<string, string> ending = new Dictionary<string, string>()
        {

            {"3-10", "teen" },
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