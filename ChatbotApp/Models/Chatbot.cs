using System;

namespace ChatbotApp.Models
{
    public class Chatbot
    {
        public string UserName { get; private set; } = string.Empty;

        public void SetUserName(string name)
        {
            UserName = name;
        }

        public string GetGreeting()
        {
            return $"Hello, {UserName}! I'm your Cybersecurity Awareness Assistant. How can I help you today?";
        }

        public string GetResponse(string input)
        {
            input = input.ToLower().Trim();

            if (input.Contains("my name is"))
            {
                var parts = input.Split(new[] { "my name is" }, StringSplitOptions.None);
                if (parts.Length > 1)
                {
                    string newName = parts[1].Trim();
                    if (!string.IsNullOrEmpty(newName))
                    {
                        SetUserName(newName);
                        return $"Nice to meet you, {UserName}! How can I assist with cybersecurity?";
                    }
                }
            }

            if (input.Contains("how are you"))
                return $"I'm functioning optimally, {UserName}! Ready to discuss cybersecurity.";

            if (input.Contains("purpose") || input.Contains("what can you do"))
                return "I'm here to educate you on cybersecurity topics like password safety, phishing, and safe browsing.";

            if (input.Contains("help") || input.Contains("what can i ask"))
                return "Ask me about password safety, phishing scams, safe browsing, or how to protect your privacy online.";

            if (input.Contains("password"))
                return "Use strong, unique passwords for each account. Consider a password manager. Never share your passwords with anyone.";

            if (input.Contains("phishing"))
                return "Be cautious of emails asking for personal info. Verify the sender before clicking links. Report suspicious emails.";

            if (input.Contains("browsing") || input.Contains("safe browsing"))
                return "Look for HTTPS in the URL, avoid suspicious downloads, and use an ad-blocker. Keep your browser updated.";

            if (input.Contains("privacy"))
                return "Review privacy settings on social media and limit the information you share publicly. Use two-factor authentication.";

            if (input.Contains("exit") || input.Contains("quit") || input.Contains("bye"))
                return "EXIT";

            return $"I didn't quite understand that. Could you rephrase? Ask about passwords, phishing, or safe browsing.";
        }
    }
}