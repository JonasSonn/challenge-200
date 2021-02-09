using Xunit; 


namespace test {
    public class solution202test {
        [Fact]
        public void TestNumber1Prime()
        {
        Assert.Equal("1 has no prime factors", solutions.solution202.ExpressFactors(1));
        }
        [Fact]
        public void TestNumber2Prime()
        {
        Assert.Equal("2", solutions.solution202.ExpressFactors(2));
        }
        [Fact]          
        public void TestNumber8PowerOff()
        {
        Assert.Equal("2^3", solutions.solution202.ExpressFactors(8));
        }
        [Fact]
        public void TestNumber10Multiplication()
        {
        Assert.Equal("2 x 5", solutions.solution202.ExpressFactors(10));
        }

       [Fact]
        public void TestNumber36DoublePowerOff()
        {
        Assert.Equal("2^2 x 3^2", solutions.solution202.ExpressFactors(36));
        }

        [Fact]
        public void TestNumber180Combies()
        {
        Assert.Equal("2^2 x 3^2 x 5", solutions.solution202.ExpressFactors(180));
        }

        [Fact]
        public void TestNumberWithLongExpression() 
        {
            Assert.Equal("2^3 x 3^5 x 5^2 x 7^2 x 11 x 13 x 17", solutions.solution202.ExpressFactors(5789183400));
        }
    }
}

/*Create a function that takes a positive integer and returns a string expressing how the number can be made by multiplying powers of its prime factors.

ExpressFactors(2) ➞ "2"
ExpressFactors(4) ➞ "2^2"
ExpressFactors(10) ➞ "2 x 5"
ExpressFactors(60) ➞ "2^2 x 3 x 5"*/