using System;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string longest = "";
            string[] splitted = text.Split(' ');
            foreach (string word in splitted)
            {
                string currentWord = Regex.Match(word, "[a-zA-Z]+").Value;
                if (currentWord.Length > longest.Length)
                {
                    longest = currentWord;
                }
            }
            return longest;
        }
    }
}
