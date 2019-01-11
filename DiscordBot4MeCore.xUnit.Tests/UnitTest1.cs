using System;
using Xunit;

namespace DiscordBot4MeCore.xUnit.Tests
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
