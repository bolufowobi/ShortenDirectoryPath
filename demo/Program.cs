using System.Linq;

namespace Demo
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            const string str = "../../foo/../../bar/baz";
            var result = Challenge.ShortenPath(str);
            Console.WriteLine(result);
        }
    }
}
