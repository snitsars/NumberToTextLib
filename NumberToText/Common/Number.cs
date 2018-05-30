namespace Demo.NumberToText.Common
{
    public class Number
    {
        public static Number GetInstance(int number)
        {
            Number result = new Number();

            result.Hundred = number / 100;
            number = number - result.Hundred*100;

            result.Ten = number / 10;
            number = number - result.Ten*10;

            result.One = number;

            return result;
        }

        public int One { get; set; }
        public int Ten { get; set; }
        public int Hundred { get; set; }
    }
}