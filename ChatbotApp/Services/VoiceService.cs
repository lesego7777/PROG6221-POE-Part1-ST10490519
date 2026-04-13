using System;
using System.IO;
using System.Media;
using System.Runtime.Versioning;

namespace ChatbotApp.Services
{
    public class VoiceService
    {
        [SupportedOSPlatform("windows")]
        public void PlayGreeting()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"[SYSTEM] Playing voice greeting: {filePath}");
                Console.ResetColor();

                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.PlaySync();
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("[SYSTEM] Voice greeting completed.");
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[SYSTEM] Audio device not available (VM limitation). Continuing...");
                Console.ResetColor();
            }
        }
    }
}