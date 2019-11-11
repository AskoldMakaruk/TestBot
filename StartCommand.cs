using BotFramework;
using BotFramework.Bot;
using BotFramework.Commands;
using Telegram.Bot.Types;

namespace TestBot
{
    public class StartCommand : StaticCommand
    {
        public override Response Execute(Message message, Client client)
        {
            return new Response(this).SendTextMessage(message.From.Id, "I'm alive!");
        }

        public override string Alias => "/start";
    }
}