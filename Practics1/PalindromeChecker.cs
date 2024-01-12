
namespace Practics1
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            var cleanedInput = new string(input.ToLower().Where(char.IsLetterOrDigit).ToArray());
            return cleanedInput.SequenceEqual(cleanedInput.Reverse());
        }
    }

}
