using System;
using DiscordBot4MeCore;
using DiscordBot4MeCore.Storage;
using DiscordBot4MeCore.Storage.Implementations;
using Xunit;

namespace UnitTests.xUnit
{
    public class UnityUnitTest
    {
        [Fact]
        public void Test1()
        {
            const int expected = 5;
            int actual = MyUtility.MyTestUtility(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestUnityNewContainer()
        {
            IDataStorage actual = DiscordBot4MeCore.Unity.Resolve<IDataStorage>();
            Assert.IsType<JsonStorage>(actual);
        }

        [Fact]
        public void TestUnityExistingContainer()
        {
            ILogger actual = DiscordBot4MeCore.Unity.Resolve<ILogger>();
            Assert.IsType<Logger>(actual);
        }
    }
}
