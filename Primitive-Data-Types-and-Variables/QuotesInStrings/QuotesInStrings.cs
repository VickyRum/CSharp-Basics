using System;
class QuotesInStrings
    {
        static void Main()
        {
            string withQuotedStrings = "The \"use\" of quotations causes difficulties.";
            string withoutQuotedStrings = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(withQuotedStrings);
            Console.WriteLine(withoutQuotedStrings);
        }
    }

