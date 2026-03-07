using System;
using System.Data.Common;

var str1 = "Something";
Console.WriteLine(ReverseString(str1));
Console.WriteLine(ReverseStringArray(str1));

static string ReverseString(string input) =>
    string.IsNullOrEmpty(input)
        ? input
        : new string(input.Reverse().ToArray());


static string ReverseStringArray(string str)
{
    if (String.IsNullOrWhiteSpace(str))
    {
        return str;
    }

    char[] chars = str.ToCharArray();
    int left = 0;
    int right = chars.Length - 1;

    while (left < right)
    {
        (chars[left], chars[right]) = (chars[right], chars[left]);
        left++;
        right--;
    }

    return new string(chars);
}