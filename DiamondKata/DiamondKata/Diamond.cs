using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata
{
    public class Diamond
    {
        private const char FirstLetter = 'A';
        private const char PaddingChar = ' ';
        private const string LineSeparator = "\n";

        public static string GenerateSingleLine(int paddingLeft, int character, int paddingMiddle)
        {
            var letter = Convert.ToChar(character);
            var line = string.Empty.PadLeft(paddingLeft, PaddingChar) + letter;

            if (letter != FirstLetter)
            {
                line += string.Empty.PadLeft(paddingMiddle, PaddingChar) + letter;
            }
            return line;
        }

        public static List<string> GenerateHalfDiamond(char middleCharacter)
        {
            var lines = new List<string>();
            int paddingLeft = middleCharacter - FirstLetter;
            int length = paddingLeft + 1;
            int paddingMiddle = 1;

            foreach (var character in Enumerable.Range('A', middleCharacter + 1 - 'A'))
            {
                lines.Add(GenerateSingleLine(paddingLeft, character, paddingMiddle));

                paddingMiddle = ++length - --paddingLeft - 2;
            }
            return lines;
        }

        public static string Create(char middleCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
