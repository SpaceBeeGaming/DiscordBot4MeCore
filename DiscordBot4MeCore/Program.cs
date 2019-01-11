using System;
using System.Threading.Tasks;
using DiscordBot4MeCore.Discord;
using DiscordBot4MeCore.Discord.Entities;
using DiscordBot4MeCore.Storage;

namespace DiscordBot4MeCore
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            IDataStorage storage = Unity.Resolve<IDataStorage>();

            Connection connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new DiscordBot4MeConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
        }
    }





}
