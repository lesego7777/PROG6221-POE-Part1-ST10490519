using System;

namespace ChatbotApp.Services
{
    public class AsciiArtService
    {
        public void DisplayLogo()
        {
            string logo = @"
   _____      _   _      _                      _           
  / ____|    | | | |    | |                    | |          
 | |    _   _| |_| |__  | |_ ___ _ __ ___  ___ | |_ ___ _ __ 
 | |   | | | | __| '_ \ | __/ _ \ '_ ` _ \/ _ \| __/ _ \ '__|
 | |___| |_| | |_| | | || ||  __/ | | | | | (_) | ||  __/ |   
  \_____\__, |\__|_| |_| \__\___|_| |_| |_|\___/ \__\___|_|   
         __/ |                                               
        |___/                                                
   Awareness Bot
";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(logo);
            Console.ResetColor();
        }
    }
}