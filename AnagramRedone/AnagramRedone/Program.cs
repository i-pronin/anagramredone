using System;
using AnagramRedoneLib;
using System.Globalization;
using System.Threading;
using AnagramRedone.Resources;

namespace AnagramRedone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string source = String.Empty;
            var anagram = new Anagram();
            Console.Write($"{Strings.InputRequest}");
            source = Console.ReadLine();
            Console.WriteLine($"SrcStr: {source}");
            Console.WriteLine($"StrOut: {anagram.ReversePhrase(source)}");
        }
    }
}