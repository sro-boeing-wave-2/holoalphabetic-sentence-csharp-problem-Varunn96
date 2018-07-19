using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            char[] charArray = input.ToLower().ToCharArray();
            charArray = charArray.Distinct().ToArray();
            Array.Sort(charArray);
            string sortedstring = String.Concat(charArray);
            bool Value = sortedstring.Contains(alphabets);
            return Value;
        }
    }
}
