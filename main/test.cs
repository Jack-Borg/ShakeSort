using System;
using System.Text.RegularExpressions;

namespace main
{
    public class test : Util
    {
        public static void testa()
        {
            //string pattern = "([A-Za-z]{1,}(['][A-Za-z]|['])?)";
            /*string pattern = "[a-z']{1,}";
            //string input = "Thou that ' 't i art \"now\" the world's fresh: ornament, it's";
            String input = "'Tis";*/
            //String input = "'Till I have no wife, I have nothing in France.'";

            /*MatchCollection matches = Regex.Matches(input, pattern);
            int commentNumber = 0;
            Console.WriteLine(input);
            foreach (Match match in matches)
                Console.WriteLine(match.Value);*/

            // This example displays the following output:
            //       [(.*?)] produces the following matches:
            //          1: ?
            //          2: ?
            //          3: .

            int[] arr = {1, 2, 3, 4};
            int[] narr = new int[4];
            arr.CopyTo(narr, 2);
            foreach (int i in narr)
            {
                Console.WriteLine(i);
            }
        }
    }
}