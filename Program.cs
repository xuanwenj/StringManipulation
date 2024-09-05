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
            //EscapeString();
            // the  main method is static, so everything it calls has to be static or instantiated 
            //AppendingStrings();
            //InterpolationAndLiteral();
            //WorkingWithArrays();
            PadAndTrim();
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

        // appending string
        private static void AppendingStrings()
        {
            string firstName = "Tim";
            string lastName = "Corey";
            string results;

            results = firstName + ", my name is " + firstName + " " + lastName;
            Console.WriteLine(results);

            results = string.Format("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(results);

            //$ - string interpolation
            // this code is the most readable one of the three
            results = $"{firstName}, my name is {firstName} {lastName}";
            Console.WriteLine(results);
        }
        // interpolation and literal
        // String interpolation in C# is a feature that allows you to embed expressions,
        // including variable values, directly within a string.
        private static void InterpolationAndLiteral()
        {
            string testString = "Tim Corey";
            string results = $@"C:\Demo\{testString}\{"\""}Test{"\""}.txt";

            Console.WriteLine(results);
        }

        private static void WorkingWithArrays()
        {
            int[] ages = new int[] { 6, 7, 8, 3, 5 };
            string results;

            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join(",", ages);
            Console.WriteLine(results);

            Console.WriteLine();

            string testString = "Jon,Tim,Mary,Sue,Bob,Jane";
            string[] resultsArray = testString.Split(',');

            Array.ForEach(resultsArray, x => Console.WriteLine(x));

            Console.WriteLine();

            testString = "Jon, Tim, Mary, Sue, Bob, Jane";
            resultsArray = testString.Split(", ");

            Array.ForEach(resultsArray, x => Console.WriteLine(x));
        }
        //trim
        private static void PadAndTrim()
        {
            string testString = "     Hello World     ";
            string results;

            results = testString.TrimStart();
            Console.WriteLine($"'{results}'");

            results = testString.TrimEnd();
            Console.WriteLine($"'{results}'");

            results = testString.Trim();
            Console.WriteLine($"'{results}'");

            testString = "1.15";

            results = testString.PadLeft(10, '0');
            Console.WriteLine(results);

            results = testString.PadRight(10, '0');
            Console.WriteLine(results);
        }


    }
}
