using System;
using System.Collections.Generic;

// public class CommonItem
// {
//  public static void Main(string[] args)
//     {
        var arr1 = new char[] { 'a', 'b', 'k', 'd' };
        var arr2 = new char[] { 'f', 'l', 'k', 'w' };
        Console.WriteLine(CheckIfCommonExists(arr1, arr2));
    // }

    static bool CheckIfCommonExists(char[] arr1, char[] arr2) {
        var set1 = new HashSet<char>(arr1);
        foreach (var item in arr2){
            if (set1.Contains(item))
            {
                return true;
            }
        }
        return false;
    }
// }

