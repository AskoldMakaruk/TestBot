using BotFramework;
using BotFramework.Bot;
using BotFramework.Commands;
using Telegram.Bot.Types;

namespace TestBot
{
    public class StartCommand : IStaticCommand
    {
        public Response Execute(Message message, Client client)
        {
            return new Response().SendTextMessage(message.From.Id, "I'm alive!");
        }

        public bool Suitable(Message message)
        {
            return message.Text == "/start";
        }
    }
}