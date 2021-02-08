using Xunit;

namespace test
{
    public class solution205testEncrypt
    {
        [Fact]
        public void EcryptGetCharCodeForA()
        {
            Assert.Equal(new int[] {65}, solutions.solution205.Encrypt("A"));
        }
        [Fact]
        public void EcryptGetCharCodeForZ()
        {
            Assert.Equal(new int[] {90}, solutions.solution205.Encrypt("Z"));
        }

         [Fact]
        public void EcryptPassNothing()
        {
            Assert.Equal(new int[] {}, solutions.solution205.Encrypt(""));
        }

         [Fact]
        public void EcryptPassSpace()
        {
            Assert.Equal(new int[] {32}, solutions.solution205.Encrypt(" "));
        }

        [Fact]
        public void EcryptPassMessage1()
        {
            Assert.Equal(new int[] {82,-13,31}, solutions.solution205.Encrypt("REd"));
        }

        [Fact]
        public void EcryptPassMessage2()
        {
            Assert.Equal(new int[] {72, 29, 7, 0, 3}, solutions.solution205.Encrypt("Hello"));
        }

        [Fact]
        public void EcryptPassMessage3()
        {
            Assert.Equal(new int[] {72, 33, -73, 84, -12, -3, 13, -13, -68}, solutions.solution205.Encrypt("Hi there!"));
        }

        [Fact]
        public void EcryptPassMessage4()
        {
            Assert.Equal(new int[] {83, 34, -7, 5, -11, 1, 5, -9}, solutions.solution205.Encrypt("Sunshine"));
        }

    }
    public class solution205testDecrypt{
        [Fact]
        public void DecryptCharCodeToA()
        {
            Assert.Equal("A", solutions.solution205.Decrypt(new int[] {65}));
        }

        [Fact]
        public void DecryptEmptyEncryption()
        {
            Assert.Equal("", solutions.solution205.Decrypt(new int[] {}));
        }

        [Fact]
        public void DecryptDoubleSpaceEcryption()
        {
            Assert.Equal("  ", solutions.solution205.Decrypt(new int[] {32, 0}));
        }

        [Fact]
        public void DecryptMessage1()
        {
            Assert.Equal("Hi there!", solutions.solution205.Decrypt(new int[] {72, 33, -73, 84, -12, -3, 13, -13, -68}));
        }
    }

}
/*
Create two functions that take a string and an array and returns a coded or decoded message.

The first letter of the string, or the first element of the array represents the Character Code of that letter. The next elements are the differences between the characters: e.g. A +3 --> C or z -1 --> y.

Examples:
Encrypt("Hello") ➞ [72, 29, 7, 0, 3]
// H = 72, the difference between the H and e is 29 (upper- and lowercase).
// The difference between the two l's is obviously 0.
Decrypt([ 72, 33, -73, 84, -12, -3, 13, -13, -68 ]) ➞ "Hi there!"
Encrypt("Sunshine") ➞ [83, 34, -7, 5, -11, 1, 5, -9]
 */