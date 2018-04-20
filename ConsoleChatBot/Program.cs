using Syn.Bot.Oscova;
using System;

namespace ConsoleChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var lblnSair = false;            

            while (!lblnSair)
            {
                var bot = new OscovaBot();
                bot.Dialogs.Add(new ChatBotDialog());
                bot.Trainer.StartTraining();

                bot.MainUser.ResponseReceived += (sender, eventArgs) =>
                {
                    Console.WriteLine($"Panelinha: {eventArgs.Response.Text}");
                };

                Console.Write("Usuário: ");
                var message = Console.ReadLine();

                var result = bot.Evaluate(message);
                result.Invoke();

                if (message.Equals("sair"))
                    lblnSair = true;
            }            
        }
    }
}
