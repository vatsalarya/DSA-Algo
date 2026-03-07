// https://coderbyte.com/editor/Longest%20Word:Csharp
// Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"

using System;

class MainClass {

  public static string LongestWord(string sen) {

    string longest = "";
    string current = "";

    foreach (char c in sen) {

      if ((c >= 'a' && c <= 'z') || 
          (c >= 'A' && c <= 'Z') || 
          (c >= '0' && c <= '9')) {

        current += c;
      }
      else {

        if (current.Length > longest.Length) {
          longest = current;
        }

        current = "";
      }
    }

    // check last word
    if (current.Length > longest.Length) {
      longest = current;
    }

    return longest;
  }

  // keep this function call here
  static void Main() {

    Console.WriteLine(LongestWord(Console.ReadLine()));
    
  } 

}