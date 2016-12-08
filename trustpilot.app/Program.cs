﻿using System;
using System.Diagnostics;
using System.IO;

namespace trustpilot.app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Looking for phrase");
            var sw = new Stopwatch();
            sw.Start();

            var anagram = "poultry outwits ants".Trim();
            var phrase = "4624d200580677270a54ccff86b9610e".ToUpper();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wordlist");

            var matched = new SecretPhrase().Find(path, anagram, phrase);
            sw.Stop();
            Console.WriteLine(matched);
            var timeInSec = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds;
            Console.WriteLine($"Time: {timeInSec} sec");
            Console.ReadLine();
        }
    }
}