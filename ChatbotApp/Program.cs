using System;
using System.Runtime.Versioning;
using ChatbotApp.Models;
using ChatbotApp.Services;

namespace ChatbotApp
{
    class Program
    {
        [SupportedOSPlatform("windows")]
        static void Main(string[] args)
        {
            // 1. Voice greeting
            var voice = new VoiceService();
            voice.PlayGreeting();

            // 2. ASCII art
            var ascii = new AsciiArtService();
            ascii.DisplayLogo();

            // 3. UI service
            var ui = new ConsoleUIService();
            ui.WriteHeader("Cybersecurity Awareness Bot");

            // 4. Chatbot instance
            var bot = new Chatbot();

            // 5. Ask for name
            ui.WriteBotMessage("Welcome! What's your name?");
            ui.WriteUserPrompt();
            string name = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(name))
                name = "User";
            bot.SetUserName(name);

            ui.WriteBotMessage(bot.GetGreeting());
            ui.WriteBotMessage("Type 'exit' to quit, or ask me about cybersecurity.");

            // 6. Main loop
            while (true)
            {
                ui.WriteUserPrompt();
                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(input))
                {
                    ui.WriteBotMessage("Please say something.");
                    continue;
                }

                string response = bot.GetResponse(input);
                if (response == "EXIT")
                {
                    ui.WriteBotMessage($"Goodbye, {bot.UserName}! Stay safe online.");
                    break;
                }

                ui.WriteBotMessage(response);
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}