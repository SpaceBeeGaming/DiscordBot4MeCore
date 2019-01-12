using System;
using DiscordBot4MeCore;
using Xunit;

namespace UnitTests.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            const int expected = 5;
            int actual = MyUtility.MyTestUtility(expected);
            Assert.Equal(expected, actual);
        }
    }
}
