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
            //PadAndTrim();
            //SearchingStrings();
            //OrderingStrings();
            TestingEquality();

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
        //search string
        private static void SearchingStrings()
        {
            string testString = "This is a test of the search. Let's see how its testing works out.";
            bool resultsBoolean;
            int resultsInt;

            resultsBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Starts with \"This is\": {resultsBoolean}");

            resultsBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Starts with \"This is\": {resultsBoolean}");

            resultsBoolean = testString.EndsWith("works out.");
            Console.WriteLine($"Ends with \"works out.\": {resultsBoolean}");

            resultsBoolean = testString.EndsWith("work out.");
            Console.WriteLine($"Ends with \"work out.\": {resultsBoolean}");

            resultsBoolean = testString.Contains("test");
            Console.WriteLine($"Contains \"test\": {resultsBoolean}");

            resultsBoolean = testString.Contains("tests");
            Console.WriteLine($"Contains \"tests\": {resultsBoolean}");

            resultsInt = testString.IndexOf("test");
            Console.WriteLine($"Index of \"test\": {resultsInt}");


            // start searching the first 'test' from position of 11, including 11
            resultsInt = testString.IndexOf("test", 11);
            Console.WriteLine($"Index of \"test\" after character 10: {resultsInt}");

            resultsInt = testString.IndexOf("test", 48);
            Console.WriteLine($"Index of \"test\" after character 48: {resultsInt}");

            // searches for the last occurrence of test from the beginning
            resultsInt = testString.LastIndexOf("test");
            Console.WriteLine($"Last Index of \"test\": {resultsInt}");
            // searches for the last occurrence of "test", starts searching backward from index 48.
            resultsInt = testString.LastIndexOf("test", 48);
            Console.WriteLine($"Last Index of \"test\" before character 48: {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 10);
            Console.WriteLine($"Last Index of \"test\" before character 10: {resultsInt}");


        }
        private static void OrderingStrings()
        {
            CompareToHelper("Mary", "Bob");
            CompareToHelper("Mary", null);
            CompareToHelper("Adam", "Bob");
            CompareToHelper("Bob", "Bob");


            CompareHelper("Mary", "Bob");
            CompareHelper("Mary", null);
            CompareHelper(null, "Bob");
            CompareHelper("Adam", "Bob");
            CompareHelper("Bob", "Bob");
            CompareHelper("Bob", "Bobby");
            CompareHelper(null, null);

        }
        //the drawback of this method is testA can not be null, because it is needed in
        //int resultsInt = testA.CompareTo(testB);


        private static void CompareToHelper(string testA, string? testB)
        {
            int resultsInt = testA.CompareTo(testB);
            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"CompareTo: {testB ?? "null"} comes before {testA}");
                    break;
                case < 0:
                    Console.WriteLine($"CompareTo: {testA} comes before {testB}");
                    break;
                case 0:
                    Console.WriteLine($"CompareTo: {testA} is the same as {testB}");
                    break;
            }
        }

        private static void CompareHelper(string? testA, string? testB)
        {
            int resultsInt = String.Compare(testA, testB);

            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"Compare: {testB ?? "null"} comes before {testA}");
                    break;
                case < 0:
                    Console.WriteLine($"Compare: {testA ?? "null"} comes before {testB}");
                    break;
                case 0:
                    Console.WriteLine($"Compare: {testA ?? "null"} is the same as {testB ?? "null"}");
                    break;
            }
        }

        private static void TestingEquality()
        {
            EqualityHelper("Bob", "Mary");
            EqualityHelper(null, "");
            EqualityHelper("", "");
            EqualityHelper("Bob", "bob");
        }

        private static void EqualityHelper(string? testA, string? testB)
        {
            bool resultsBoolean;

            resultsBoolean = String.Equals(testA, testB);
            if (resultsBoolean)
            {
                Console.WriteLine($"Equals: '{testA ?? "null"}' equals '{testB ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"Equals: '{testA ?? "null"}' does not equal '{testB ?? "null"}'");
            }
        }



    }
}
