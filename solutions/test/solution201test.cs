using Xunit;

namespace test
{
    public class solution201test
    {
        [Fact]
        public void PassEmptyEqualEmpty()
        {
        Assert.Equal("", solutions.solution201.Maskify(""));
        }

        [Fact]
        public void InputLongerThanFourMaskExceptLastFour(){
            Assert.Equal("X2345", solutions.solution201.Maskify("12345"));
        }

        [Fact]
        public void Input2LongerThanFourMaskExceptLastFour(){
            Assert.Equal("XXXXXXX8910", solutions.solution201.Maskify("12345678910"));
        }

        [Theory]
        [InlineData("1")]
        [InlineData("12")]
        [InlineData("123")]
        [InlineData("1234")]
        public void InputNoLessThanFourEqualInput(string number){
            Assert.Equal(number, solutions.solution201.Maskify(number));
        }

   
    }
}
