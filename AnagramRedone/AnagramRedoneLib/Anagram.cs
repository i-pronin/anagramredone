using System;
using System.Linq;

namespace AnagramRedoneLib
{
    public class Anagram
    {

        /// <summary>
        ///  Reverses the phrase
        /// </summary>
        /// <param name="source">User input string</param>
        /// <returns>Reversed string</returns>
        public string ReversePhrase(string source)
        {
            if (String.IsNullOrWhiteSpace(source))
            {
                return source;
            }
            string[] words = source.Split(new char[] { ' ', '\t' });
            string temp = String.Empty;
            int count = 0;
            foreach (string word in words)
            {
                    
                if (count == 0)
                {
                    temp = ReverseWord(word);
                }
                else
                {
                    temp += source[temp.Length] + ReverseWord(word);
                }
                count++;
            }
            return temp;
        }

        /// <summary>
        /// Reverses all letters in one word
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Reversed word</returns>
        private string ReverseWord(string word)
        {
            int rightIndex = word.Length - 1;
            int leftIndex = 0;
            char[] letterArray = word.ToCharArray();
            while (leftIndex < rightIndex)
            {
                if (!char.IsLetter(letterArray[leftIndex]))
                {
                    leftIndex++;
                }
                else if (!char.IsLetter(letterArray[rightIndex]))
                {
                    rightIndex--;
                }
                else
                {
                    char temp = letterArray[leftIndex];
                    letterArray[leftIndex] = letterArray[rightIndex];
                    letterArray[rightIndex] = temp;
                    leftIndex++;
                    rightIndex--;
                }
            }
            return new string(letterArray);
        }
    }
}

