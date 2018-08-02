using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringConsole.Source;

namespace StringConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>
            {
                "al",
                "albums",
                "aver",
                "bar",
                "barely",
                "be",
                "befoul",
                "bums",
                "by",
                "cat",
                "con",
                "convex",
                "ely",
                "foul",
                "here",
                "hereby",
                "jig",
                "jigsaw",
                "or",
                "saw",
                "tail",
                "tailor",
                "vex",
                "we",
                "weaver"
            };
            foreach (var sixLetterString in StringFilter
                .SixLetterStringsStartWithSmallLetterStrings(strings))
            {
                Console.WriteLine(sixLetterString);
            }
            Console.ReadLine();
        }
    }
}
