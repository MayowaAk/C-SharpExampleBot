using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace C_SharpExampleBot.Commands
{
    public class InformationCommands : BaseCommandModule
    {
        [Command("help"), /*Aliases("", "") Uncomment this out and add whatever alias you want for the command if you want to use aliases*/] 
        public async Task HelpCommand(CommandContext ctx)
        {
            await ctx.RespondAsync("Here are the available commands");
        }
    }
}
