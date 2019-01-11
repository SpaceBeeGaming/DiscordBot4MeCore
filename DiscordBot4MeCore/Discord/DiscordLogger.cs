using System.Threading.Tasks;

using Discord;

namespace DiscordBot4MeCore.Discord
{
    public class DiscordLogger
    {
        private ILogger _logger;

        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }

        public Task Log(LogMessage logMessage)
        {
            _logger.Log(logMessage.Message);
            return Task.CompletedTask;
        }
    }
}
