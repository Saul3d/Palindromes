using System;
using Palindromes;
using Xunit;

namespace Palindromes.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestWhetherWordIsAPalindrome()
        {
            // Arrange
            var word = "Stars";
            var palindromeTester = new Palindrome();

            // Act
            var result = palindromeTester.checkIfPalindromeWord(word);

            // Asset
            Assert.False(result);
        }

        [Fact]
        public void TestWhetherWordIsAPalindrome1()
        {
            // Arrange
            var word = "O, a kak Uwakov lil vo kawu kakao!";
            var palindromeTester = new Palindrome();

            // Act
            var result = palindromeTester.checkIfPalindromeWord(word);
            Console.WriteLine(result);
            
            //Asset
            Assert.True(result);
        }

        [Fact]
        public void TestWhetherWordIsPalindrome2()
        {
            // Arrange
            var word = "Some men interpret nine memos";
            var palindromeTester = new Palindrome();

            //Act
            var result = palindromeTester.checkIfPalindromeWord(word);
            Console.WriteLine(result);

            //Asset
            Assert.True(result);

        }
    }
}
