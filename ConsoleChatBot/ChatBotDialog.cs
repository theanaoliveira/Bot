using Syn.Bot.Oscova;
using Syn.Bot.Oscova.Attributes;
using System.Diagnostics;

namespace ConsoleChatBot
{
    class ChatBotDialog : Dialog
    {
        [Expression("Oi")]
        [Expression("Ola")]
        [Expression("Hello")]
        public void HelloBot(Result result)
        {
            var response = new Response
            {
                Text = "Olá!",
                Format = ResponseFormat.Html
            };

            result.SendResponse(response);
        }

        [Expression("Tudo bem?")]
        public void HelloBot2(Result result)
        {
            result.SendResponse("Tudo otimo, e com você?");
        }

        [Expression("")]
        public void HelloBotGeral(Result result)
        {
            result.SendResponse("Desculpe, não entendi");
        }
    }
}
