using Practics1;

namespace TestPractics1
{
    
    [TestFixture]
    public class PalindromeCheckerTests
    {
        private PalindromeChecker checker;

        [SetUp]
        public void SetUp()
        {
            checker = new PalindromeChecker();
        }

        [TestCase("Racecar", ExpectedResult = true)]
        [TestCase("Palindrome", ExpectedResult = false)]
        [TestCase("A man, a plan, a canal, Panama", ExpectedResult = true)]
        [TestCase("", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = false)]
        public bool PalindromeCheck_ReturnsCorrectResult(string input)
        {
            return checker.IsPalindrome(input);
        }
    }

}
