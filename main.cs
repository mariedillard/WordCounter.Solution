using System;
using System.Collections.Generic;
using System.Linq;

class WordCounter
{
  public class Program
  {
    public static void Main() {
      Console.WriteLine("Hi! I'm a program to help you find how many words you've used in a sentence!");
      Console.WriteLine("Enter your sentence here:");
      string userInput = Console.ReadLine();
      Console.WriteLine("Enter the word you'd like to search for.");
      string userWord = Console.ReadLine();

      string inputAlphanumeric = String.Concat(userInput.Where(c => Char.IsWhiteSpace(c) || Char.IsLetterOrDigit(c)));
      string inputLower = inputAlphanumeric.ToLower();
      string[] trueInput = inputLower.Split();

      string wordAlphanumeric = String.Concat(userWord.Where(c => Char.IsWhiteSpace(c) || Char.IsLetterOrDigit(c)));
      string trueWord = wordAlphanumeric.ToLower();

      int foundNumbers = 0;
      if (trueWord.Length == 0 || trueInput.Length == 0)
      {
        Console.WriteLine("One or more fields left blank! Please try again.");
      } else {
        for (int i = 0; i < trueInput.Length; i++)
        {
          if (trueInput[i].Contains(trueWord))
          {
            foundNumbers ++;
          }
        }
        Console.WriteLine("You used the word" + " *" + userWord + "* " + foundNumbers + " time(s).");
      }
    }
  }
}
