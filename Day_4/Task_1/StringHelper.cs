using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class StringHelper
    {
        public static bool IsPalindrome(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            var cleanedText = text.Replace(" ", "").ToLower();
            var length = cleanedText.Length;

            for (var i = 0; i < length / 2; i++)
            {
                if (cleanedText[i] != cleanedText[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
