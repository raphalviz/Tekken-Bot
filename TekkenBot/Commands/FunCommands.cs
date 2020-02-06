using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TekkenBot.Commands
{
    class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("add")]
        public async Task Add(CommandContext ctx, int numOne, int numTwo)
        {
            await ctx.Channel.SendMessageAsync((numOne + numTwo).ToString()).ConfigureAwait(false);
        }
    }
}
