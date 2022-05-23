using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        if (s.StartsWith("12") && s.EndsWith("AM"))
        {
            return s.Replace("12:", "00:").Remove(s.Length - 2);
        }
        else if (!s.StartsWith("12") && s.EndsWith("PM"))
        {
            var hour = s.Split(':')[0];

            var convertToMilitary = (int.Parse(hour) + 12).ToString();

            return s.Replace(hour, convertToMilitary).Remove(s.Length - 2);
        }

        return s.Remove(s.Length - 2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
