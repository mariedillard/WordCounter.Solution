using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
  public class RepeatCounter
  {
    public static bool testOne ()
    {
      string userInput = "Hey, how are you! This 1 is a dog, this 1 is a dog too. This1 is a dog!";
      string inputAlphanumeric = String.Concat(userInput.Where(c => Char.IsWhiteSpace(c) || Char.IsLetterOrDigit(c)));
      string inputLower = inputAlphanumeric.ToLower();
      string[] trueInput = inputLower.Split();
      int foundNumbers = 0;
      string userWord = "dog";
      for (int i = 0; i < trueInput.Length; i++)
      {
        if (trueInput[i].Contains(userWord))
        {
          foundNumbers ++;
        }
      }
      if (foundNumbers == 3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static bool testTwo ()
    {
      string userInput = "Hey, how are you! This 1 is a dog, this 1 is a dog too. This1 is a dog!";
      string inputAlphanumeric = String.Concat(userInput.Where(c => Char.IsWhiteSpace(c) || Char.IsLetterOrDigit(c)));
      string inputLower = inputAlphanumeric.ToLower();
      string[] trueInput = inputLower.Split();
      int foundNumbers = 0;
      string userWord = "1";
      for (int i = 0; i < trueInput.Length; i++)
      {
        if (trueInput[i].Contains(userWord))
        {
          foundNumbers ++;
        }
      }
      if (foundNumbers == 3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static bool testThree ()
    {
      string userInput = "DOG! DOG! DOG";
      string inputAlphanumeric = String.Concat(userInput.Where(c => Char.IsWhiteSpace(c) || Char.IsLetterOrDigit(c)));
      string inputLower = inputAlphanumeric.ToLower();
      string[] trueInput = inputLower.Split();
      int foundNumbers = 0;
      string userWord = "dog";
      for (int i = 0; i < trueInput.Length; i++)
      {
        if (trueInput[i].Contains(userWord))
        {
          foundNumbers ++;
        }
      }
      if (foundNumbers == 3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
