using System;
using Xunit;

namespace XUnitTestCalculator
{
    public class XUnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
            Assert.Equal(0, Subtract(2, 2));
            Assert.Equal(1, Divide(2, 2));
            Assert.Equal(6, Multiply(3, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
            Assert.Equal(5, Subtract(2, 2));
            Assert.Equal(5, Divide(2, 2));
            Assert.Equal(8, Multiply(3, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }


        int Subtract(int x, int y)
        {
            return x - y;
        }

        int Divide(int x, int y)
        {
            return x / y;
        }

        int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
