using System;
using Xunit;
using Lab4._3;

namespace Lab4._3Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(4, 7)]
        [InlineData(7, 17)]
        [InlineData(10, 29)]
        [InlineData(17, 59)]

        public void Test1(int location, int expected)
        {
            Assert.Equal(expected, Prime.GetPrime(location));
        }

    }
}
