using System;
using System.Collections.Generic;
using System.Linq;

namespace StringConsole.Source
{
    public static class StringFilter
    {
        
        //Summary
        //Return six letter strings which start with small letter strings.

        //Room for improvement.
        //1) Error messages should be revisited.
        //2) Could return six letter strings which end with small letter strings.
        //3) As the String filter class grows, some of the private and some of the public 
        //methods in it could be refactored or moved to another class.

        //What is good about this solutions.
        //Functional thinking allowed me to focus more on what needs to be done
        //rather than how it to be done. 

        public static List<string> SixLetterStringsStartWithSmallLetter(
            List<string> strings)
        {
            if (EmptyInputStrings(strings))
            {
                throw new Exception(
                    "Input strings should not be empty. Please provide an input.");
            }

            var sixLetterStrings = StringFilter.SixLetterStrings(strings);
            var smallLetterStrings = StringFilter.SmallLettersStrings(strings);

            if (OnlySixLetterStrings(sixLetterStrings, smallLetterStrings))
            {
                throw new Exception(
                    "Only six letter strings available in the input. Needs to have at least one small string which is not six letters.");
            }

            if (OnlySmallLetterStrings(smallLetterStrings, sixLetterStrings))
            {
                throw new Exception(
                    "Only small letters strings available in the input. Needs to have at least one six-letter strings.");
            }

            return (from sixLetterString in sixLetterStrings
                from smallLettersString in smallLetterStrings
                where sixLetterString.StartsWith(smallLettersString)
                select sixLetterString).ToList();
        }

        private static bool EmptyInputStrings(IEnumerable<string> strings)
        {
            return !strings.Any();
        }

        private static bool OnlySmallLetterStrings(List<string> smallLetterStrings,
            List<string> sixLetterStrings)
        {
            return smallLetterStrings.Count > 0 &&
                   sixLetterStrings.Count <= 0;
        }

        private static bool OnlySixLetterStrings(List<string> sixLetterStrings,
            List<string> smallLetterStrings)
        {
            return sixLetterStrings.Count > 0 &&
                   smallLetterStrings.Count <= 0;
        }

        public static List<string> SixLetterStrings(IEnumerable<string> strings)
        {
            var sixLetter = 6;
            return strings.Where(s => s.Length == sixLetter).Distinct().ToList();
        }

        public static List<string> SmallLettersStrings(IEnumerable<string> strings)
        {
            var sixLetter = 6;
            return strings.Where(s => s.Length != sixLetter).Distinct().ToList();
        }


    }
}