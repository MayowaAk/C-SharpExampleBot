using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace C_SharpExampleBot.Commands
{
    public class ModerationCommands : BaseCommandModule
    {
        //Base ban command with regular text
        [Command("ban"), Aliases("outlaw")]
        [Description("Bans the selected user")]
        [RequireBotPermissions(Permissions.BanMembers)]
        [RequireUserPermissions(Permissions.BanMembers)]
        public async Task BanUser(CommandContext ctx, DiscordMember discordMember, string banReason)
        {
            await discordMember.BanAsync(2, banReason);

            await ctx.RespondAsync($"{discordMember.DisplayName + discordMember.Discriminator} has been banned from {ctx.Guild.Name} for {banReason}");
            await discordMember.SendMessageAsync($"You have been banned from {ctx.Guild.Name} for {banReason}");
        }
        
        /*Ban Command with embeds
        [Command("ban"), Aliases("outlawe")]
        [Description("Bans a selected user")]
        public async Task BanUserWithEmbed(CommandContext ctx, DiscordMember discordMember, string banReason)
        {
            await discordMember.BanAsync(2, banReason);

            DiscordEmbedBuilder banEmbed = new DiscordEmbedBuilder();
            banEmbed.Title = "Ban Report";
            banEmbed.Description = $"User {discordMember.DisplayName + discordMember.Discriminator} has been banned from {ctx.Guild.Name} for {banReason} by {ctx.User.Username}";
            banEmbed.WithAuthor(ctx.User.Username);
            banEmbed.Color = DiscordColor.Red;

            await ctx.RespondAsync(banEmbed);
            await discordMember.SendMessageAsync($"You have been banned from {ctx.Guild.Name} for {banReason}");
        }
        */

        //Kick Command with regular text
        [Command("kick"), Aliases("remove")]
        [Description("Kicks the selected user")]
        [RequireBotPermissions(Permissions.KickMembers)]
        [RequireUserPermissions(Permissions.KickMembers)]
        public async Task KickUser(CommandContext ctx, DiscordMember discordMember, string kickReason)
        {
            await discordMember.RemoveAsync(kickReason);
            
            await ctx.RespondAsync($"User {discordMember.DisplayName + "#" + discordMember.Discriminator} has been kicked from {ctx.Guild.Name} for {kickReason} by {ctx.User.Username}");
        }


        /*Kick Command using embeds
        [Command("kick"), Aliases("remove")]
        [Description("Kicks the selected user")]
        [RequireBotPermissions(Permissions.KickMembers)]
        [RequireUserPermissions(Permissions.KickMembers)]
        public async Task KickUserWithEmbed(CommandContext ctx, DiscordMember discordMember, string kickReason)
        {
            await discordMember.RemoveAsync(kickReason);
            DiscordEmbedBuilder kickEmbed = new DiscordEmbedBuilder();
            kickEmbed.Title = "Kick Report";
            kickEmbed.Description = $"User {discordMember.DisplayName + "#" + discordMember.Discriminator} has been kicked from {ctx.Guild.Name} for {kickReason} by {ctx.User.Username}";
            kickEmbed.Color = DiscordColor.Red;
            await ctx.RespondAsync(kickEmbed);
        }
        */
    }
}
