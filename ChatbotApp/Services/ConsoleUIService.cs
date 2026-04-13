using System;

namespace ChatbotApp.Services
{
    public class ConsoleUIService
    {
        public void WriteBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bot> ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public void WriteUserPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You> ");
            Console.ResetColor();
        }

        public void WriteHeader(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(text);
            Console.WriteLine(new string('=', 50));
            Console.ResetColor();
        }
    }
}