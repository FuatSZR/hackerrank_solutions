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
        bool twelveAM = false;
        int hour = Convert.ToInt32(s.Substring(0, 2));
        if (hour+12==24) twelveAM = true;
        string newHour = s.Remove(8);
        newHour = newHour.Remove(0,2);
        if (s.Contains('A'))
        {
            if (twelveAM) return "00" + newHour;
            else
            {
                if (hour<12)
                {
                    return "0"+Convert.ToString(hour) + newHour;
                }
                else return Convert.ToString(hour) + newHour;

            }
        }
        else
        {
            if (twelveAM) return "12" + newHour;
            else return Convert.ToString(hour+12) + newHour;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string result = Result.timeConversion("01:00:00AM");
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
