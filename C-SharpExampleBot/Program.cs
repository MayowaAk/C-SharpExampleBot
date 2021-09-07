using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using C_SharpExampleBot.Commands;

namespace C_SharpExampleBot
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "", //Insert your bot token from the discord developer page or the bot won't run
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "!" } //Change the prefix to whatever you feel comfortable with
            });

            //commands.RegisterCommands<InformationCommands>();
            commands.RegisterCommands<ModerationCommands>();
            
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
