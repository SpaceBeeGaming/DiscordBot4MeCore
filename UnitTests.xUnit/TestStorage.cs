using System;
using System.Collections.Generic;
using System.Text;
using DiscordBot4MeCore.Storage.Implementations;
using Newtonsoft.Json;
using Xunit;

namespace UnitTests.xUnit
{
    public class TestStorage
    {
        [Fact]
        public void TestJsonStoragePathKey()
        {
            const string key = "Config/TestKey1";
            const string dataToStore = "ABC";
            JsonStorage storage = new JsonStorage();
            storage.StoreObject(dataToStore, key);

            string dataFromStorage = storage.RestoreObject<string>(key);
            Assert.Equal(expected: dataToStore, actual: dataFromStorage);
        }

        [Fact]
        public void TestJsonStorageNoPathKey()
        {
            const string key = "TestKey2";
            const string dataToStore = "ABC";
            JsonStorage storage = new JsonStorage();
            storage.StoreObject(dataToStore, key);

            string dataFromStorage = storage.RestoreObject<string>(key);
            Assert.Equal(expected: dataToStore, actual: dataFromStorage);
        }

        [Fact]
        public void TestJsonStorageLoadWrongKey()
        {
            const string key = "tesd";
            JsonStorage storage = new JsonStorage();
            storage.RestoreObject<string>(key);
        }

        [Fact]
        public void TestJsonStorageStoreEmptyKey()
        {
            const string key = "";
            const string dataToStore = "ABC";

            JsonStorage storage = new JsonStorage();
            storage.StoreObject(dataToStore, key);
        }

        [Fact]
        public void TestJsonStorageStoreNullKey()
        {
            const string key = null;
            const string dataToStore = "ABC";

            JsonStorage storage = new JsonStorage();
            storage.StoreObject(dataToStore, key);
        }

        //[Fact]
        //public void TestInMemoryStorageKey()
        //{

        //}
    }
}
