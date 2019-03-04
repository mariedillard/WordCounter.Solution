using System;
using System.Linq;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class Counter
    {
        private static string _userWriting;
        private static string _userWord;
        private static int foundCount = 0;
        
        public static void ClearAll()
        {
            _userWriting = "";
            _userWord = "";
            foundCount = 0;
        }

        public static string GetWriting()
        {
            return _userWriting;
        }

        public static void SetWriting(string userWriting)
        {
            _userWriting = userWriting;
        }

        public static string GetWord()
        {
            return _userWord;
        }

        public static void SetWord(string userWord)
        {
            _userWord = userWord;
        }

        public static int GetCount()
        {
            string wordAlphaNumeric = String.Concat(_userWord.Where(c => Char.IsWhiteSpace(c) || Char.IsLetterOrDigit(c)));
            string userWord = wordAlphaNumeric.ToLower();
            string writingAlphaNumeric = String.Concat(_userWriting.Where(c => Char.IsWhiteSpace(c) || Char.IsLetterOrDigit(c)));
            string writingLowercase = writingAlphaNumeric.ToLower();
            string[] userWriting = writingLowercase.Split();

            for (int i = 0; i < userWriting.Length; i++)
            {
                if (userWriting[i].Contains(userWord))
                {
                    foundCount ++;
                }
            }
            return foundCount;
        }

    }
}