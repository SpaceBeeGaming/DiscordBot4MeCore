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
        public void TestUnityNewContainer()
        {
            DiscordBot4MeCore.Unity.Resolve<IDataStorage>();
        }

        [Fact]
        public void TestUnityExistingContainer()
        {
            DiscordBot4MeCore.Unity.Resolve<ILogger>();
        }
    }
}
