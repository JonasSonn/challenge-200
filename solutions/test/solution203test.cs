using Xunit;

namespace test
{
    public class solution203test
    {
        int[] primesStub = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        int[] primesStubTiny = {2, 83, 89, 97 };

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(9)]
        public void passNonPrime(int nonPrime)
        {
            Assert.Equal("No", solutions.solution203.IsPrime(primesStub, nonPrime));
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(89)]
        [InlineData(97)]
        public void passPrimeExpectYes(int prime)
        {
            Assert.Equal("Yes", solutions.solution203.IsPrime(primesStub, prime));
        }
    }
}