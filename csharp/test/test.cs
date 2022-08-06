using System;
using System.Text.RegularExpressions;

public static class MatchingBrackets
{
    public static bool Main(string[] args)
    {
        string input = "[hhhjjkjf]{hhhhd}";
        string ret = Regex.Replace(input,"[^[]{}()]","");
        Console.WriteLine(ret);
    }


}