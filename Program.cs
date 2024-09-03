using System;
using System.Globalization;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //StringConversion();
            //StringAsArray();
            EscapeString();
            // the  main method is static, so everything it calls has to be static or instantiated 

        }

        private static void StringConversion()
        {
            string testString = "tHis is tHe DDI Calling!";
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
        private static void StringAsArray()
        {
            string testString = "Temi";
            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString[i]);

            }
        }
        //skip strings
        private static void EscapeString()
        {
            string results;

            results = "This is my \"test\" solution.";
            Console.WriteLine(results);

            results = "C:\\Demo\\Test.txt";
            Console.WriteLine(results);
            // @ is call string literal, with this, you can directly use \ in strings,
            // the drawback is it can't include ""

            results = @"C:\\Demo\\Test.txt";
            Console.WriteLine(results);
        }
    }
}
