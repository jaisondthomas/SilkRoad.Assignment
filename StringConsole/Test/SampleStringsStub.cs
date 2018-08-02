using System.Collections.Generic;

namespace StringConsole.Test
{
    public static class SampleStringsStub
    {
        public static List<string> Strings()
        {
            return new List<string>
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
                "weaver",
                "albums"

            };
        }

        public static List<string> OnlySixLetterStrings()
        {
            return new List<string>
            {
               
                "albums",
                "barely",
                "befoul",
                "convex",
                "hereby",
                "jigsaw",
                "tailor",
                "weaver"
            };
        }

        public static List<string> OnlySmallLetterStrings()
        {
            return new List<string>
            {
                "al",
                "aver"
                
            };
        }

        public static List<string> DuplicateSixLetterStrings()
        {
            return new List<string>
            {
                "al",
                "albums",
                "bar",
                "barely",
                "albums"
                

            };
        }

        public static IEnumerable<string> DuplicateSmallLetterStrings()
        {
            return new List<string>
            {
                "al",
                "albums",
                "bar",
                "barely",
                "albums",
                "al"

            };
        }

        public static IEnumerable<string> LargerThanSixLetterStrings()
        {
            return new List<string>
            {

                "albums",
                "barely",
                "befoul",
                "convex",
                "hereby",
                "jigsaw",
                "tailor",
                "weaver",
                "albumssssss",
            };
        }
    }
}