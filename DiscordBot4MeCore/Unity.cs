using Discord.WebSocket;
using DiscordBot4MeCore.Discord;
using DiscordBot4MeCore.Storage;
using DiscordBot4MeCore.Storage.Implementations;

using Unity;
using Unity.Injection;
using Unity.Resolution;

namespace DiscordBot4MeCore
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterSingleton<IDataStorage, JsonStorage>();
            _container.RegisterSingleton<ILogger, Logger>();
            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => SocketConfig.GetDefault()));
            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            _container.RegisterSingleton<Connection>();

        }

        public static T Resolve<T>() => (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
    }
}
