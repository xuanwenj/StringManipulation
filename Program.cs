using System;
using System.Globalization;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            StringConversion();
        }

        private static void StringConversion()
        {
            string testString = "tHis is tHe DDD Calling!";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            TextInfo englishTextInfo = new CultureInfo("en-US", false).TextInfo;
            string result;

            result = testString.ToLower();
            Console.WriteLine(result);

            result = testString.ToUpper();
            Console.WriteLine(result);

            result = englishTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);
        }
    }
}
