using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TimeConversion
{
    class Program
    {
        /*
         * Complete the timeConversion function below.
         */
        static string timeConversion(string s)
        {
            String pattern = "(:)";
            string[] sArr = new string[5];
            int i = 0;

            foreach (string x in Regex.Split(s.Remove(8), pattern))
            {
                sArr[i] = x; i++;
            }

            if (s.Contains('P'))
                sArr[0] = sArr[0] != "12" ? (Convert.ToInt32(sArr[0]) + 12).ToString() : sArr[0];

            else
                sArr[0] = sArr[0] == "12" ? "00" : sArr[0];

            return string.Join("", sArr);
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
