using System.Linq;

namespace TreCasesPasswordSamlet
{
    public class Case3Password
    {
        public static bool MinimumLength(string Text)
        {
            if (Text.Length > 11)
            {
                return (true);
            }
            return (false);
        }
        public static bool UpperAndLower(string Text)
        {
            if (Text.Any(char.IsUpper) && Text.Any(char.IsLower))
            {
                return (true);
            }
            return (false);
        }
        public static bool IncludesNumbers(string Text)
        {
            if (Text.Any(d => char.IsDigit(d)))
            {
                return (true);
            }
            return (false);
        }
        public static bool NoNumbersAtStartOrEnd(string Text)
        {
            if (char.IsDigit(Text[0]) && char.IsDigit(Text[Text.Length])) // sidste bogstav tjek fungerer ikke helt.
            {
                return (false);
            }
            return (true);
        }
        public static bool DoesNotContainSpaces(string Text)
        {
            if (Text.Contains(" "))
            {
                return (false);
            }
            return (true);
        }
    }
}