using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            bool[] confirm = new bool[26];
            input = input.ToLower();
            for (int i = 0; i < alphabets.Length; i += 1)
            {
                confirm[i] = false;
                for (int j = 0; j < input.Length; j += 1)
                {
                    if (alphabets[i] == input[j])
                        confirm[i] = true;
                }
            }
            bool output = false;
            int count = 0;
            for(int i = 0; i < confirm.Length; i += 1)
            {
                if (confirm[i] == true)
                    count += 1;
            }
            if (count == 26) output = true;
            return output;
        }
    }
}
