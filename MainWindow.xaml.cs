using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
// using System.Media;
using System.Windows;
using System.Threading;


namespace CyberSecurityChatBot
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, List<string>> responses;
        private Random random = new Random();

        private string userName = "";
        private string lastTopic = "";
        private string favouriteTopic = "";

        public MainWindow()
        {
            InitializeComponent();

            LoadAsciiArt();

            PlayGreeting();

            SetupResponses();

            BotMessage("Hello There!");
            BotMessage("What is your name?");
        }

        private void UserInput_KeyDown(object sender, KeyEventArgs e)
{
    if (e.Key == Key.Enter)
    {
        SendButton_Click(sender, e);
    }
}
        private void SetupResponses()
        {
            responses = new Dictionary<string, List<string>>()
            {
                {
                    "purpose",
                    new List<string>()
                    {
                        "I am Cipher\n"+
                        "I am a chatbot made to educate and provide some insight to cybersecurity and tech-related security measures.\n"+
                        "I was made in 2026 as an attempt to counter the increasing number of cyberattacks that were taking place.\n"+
                        "Since most people are not as aware about the potential dangers and risks that come with technology, there are people who take exploit that to their own benefit\n"+
                        "So if you are eager to learn, go ahead and ask any cyberesecurity-related questions you may be qurious about"
                    }
                },

                {
                    "hacking",
                    new List <string>()
                    {
                        "Cybersecurity is the practice of protecting systems, networks, and programs from digital attacks, commonly called cyberattacks or hacking"+
                        "Think of cybersecurity as the digital versions of superheroes who stop the villains who try to rob banks"+
                        "But in this case, the villains are doing it through the internet, and no one is held at gunpoint."+
                        "These cyberattacks are usually aimed at accessing, modifying, or destroying restricted sensitive information; extorting money from users through ransomware, or interrupting normal business processes."+
                        "Now we can try to prevent cyberattacks by implementing effective cybersecuritytechniques"+
                        "Effective techniques can work the best when they prevent damage to critical before they are even attacked, thus keeping all systems running at 100%"+
                        "So that's it :)",
                    }
                },

                {
                    "hacked",
                    new List <string>()
                    {
                        "So if you believe you have been exposed or potentially given away sensitive information, you should hurry to protect your accounts."+
                        "The reason for hurrying is because if an attacker got access to your account, it is possible that they can log YOU out of your own account."+
                        "It is therefore crucial that you act fast if this happens, you can "+
                        "Change your passwords\n"+
                        "Sign out on all devices that may have access to your account\n"+
                        "If you may have given away banking information, block your cards and ask the bank for new ones.\n"+
                        "This should prevent a lot of damage which could be critical to your assets/personal information but it doesn't guarantee that you will be fully protected\n"

                    }
                },

                {
                    "what is hacking",
                    new List <string>()
                    {
                        "In simple terms, hacking is a term used to explain an illegal digital attack on systems. It is the foundation that cybersecurity works towards fighting"
                    }
                },

                {
                    "password",
                    new List<string>()
                    {
                        "Use strong passwords with numbers and symbols.\n",
                        "Never reuse passwords across multiple accounts.\n",
                        "A password manager can help keep passwords secure.\n"
                    }
                },


                {
                    "phishing",
                    new List<string>()
                    {
                        "Phishing is a dangerous tactic used by attackers to trick users to granting unauthorized access to sensitive information\n"+
                        "To prevent phishing attacks:\n"+
                        "Never click suspicious email links.\n"+
                        "Check the sender before opening attachments.\n"+
                        "Phishing scams often create fake urgency.\n"
                    }
                },

                {
                    "privacy",
                    new List<string>()
                    {   
                        "When it comes to privacy-related concerns, you should"+
                        "Review your privacy settings regularly and read through the updates they get",
                        
                        "When it comes to privacy-related concerns, you should "+
                        "Avoid oversharing personal information online.",

                        "When it comes to privacy-related concerns, you should "+
                        "Enable two-factor authentication for more protection."
                    }
                },

                {
                    "scam",
                    new List<string>()
                    {
                        "Scammers often pretend to be trusted companies."+
                        "Therefore, never EVER share OTPs with anyone."+
                        "And Always verify suspicious messages."
                    }

                },

                {
                    "safe",
                    new List <string>()
                    {
                        "When you use a computer or the internet, you may think you are just accessing the information you want, but in the background, a lot could be happening:\n"+
                        "Your activity could be monitored, you could be observed by malicious software made to steal your passwords\n"+
                        "You could even be tricked into clicking on unsafe links that give attackers access to all your sensitive information.\n"+
                        "And the worst part is that you wouldn’t even know until it’s too late."+

                        "So here are a few things you can do to prevent this from happening:\n"+
                        "Be cautious with links and attachments\n"+
                        "A new and arising dangerous attack used today is link redirection."+
                        "You click on a link that is intended to take you to your planned website, but it redirects you to a fake similar webpage"+
                        "More often, users cannot tell the difference, so they enter their personal information."+
                        "Verify the link before you click on it and check if it says that it will take you to where you want it to"+
                        "You could also use an online link verifier to ensure that it is safe to click.\n"+
                        "Remember the phrase: think before you click\n\n"+

                        "Use strong unique passwords\n"+
                        "As the everyday systems we use develop, we are encouraged to come up with strong passwords that would be difficult to guess or predict\n"+
                        "Even so, you could still be at risk.\n"+
                        "As unique as your password may be, you shouldn’t reuse the same one across sites.\n"+
                        "If one were to get their hands on it, they would have access to all the other sites with all your personal information\n\n"+

                        "Limit the amount of personal information you share online\n"+
                        "As you explore various platforms, you will find yourself encouraged to share personal details to further improve your user experience"+
                        "Many don’t realize how much information is being collected over time"+
                        "Most already try their best to protect their data but regardless, companies still try to obtain some level of data from usersMost already try their best to protect their data but regardless, companies still try to obtain some level of data from users"+

                        "Recognize emotional manipulation online\n"+
                        "A lot of online threats, commonly scams rely on the psychological sense of urgency, fear, or excitement to persuade users to perform quick reactions to satisfy those emotions."+
                        "Examples of this could be a bank telling you that your account was potentially hacked and requires immediate attention." +
                        "It is best advised to take a moment to think before you click or respond in order to break that psychological pattern." +
                        "Slowing down is the most effective defences against manipulation-driven attacks.\n"+

                        "Treat online safety as an ongoing habit\n"+
                        "You need to understand that cybersecurity is a process, a habit and not a single one-time setup that works forever. " +
                        "As technology evolves, so do security threats and precautions that worked perfectly a year ago may not be sufficient in today’s time. " +
                        "Try to stay informed about potential dangers, continue to perform basic practices, and apply pattern recognition as you use these daily systems.\n" +
                        "You would be surprised how many users have been a victim and how it’s not all just theory and risk."


                        
                    }
                }
            };
        }

        
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string input = UserInput.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            UserMessage(input);

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = input;

                BotMessage($"Welcome {userName}. It is nice to meet you, {userName}!");
                BotMessage("Ask me anything about cybersecurity.");

                UserInput.Clear();
                return;
            }

            DetectSentiment(input);

            bool found = false;

            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    lastTopic = keyword;

                    if (keyword == "privacy")
                    {
                        favouriteTopic = "privacy";
                    }

                    var topicResponses = responses[keyword];

                    string response =
                        topicResponses[random.Next(topicResponses.Count)];

                    BotMessage(response);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                if (input.Contains("tell me more") ||
                    input.Contains("another tip") ||
                    input.Contains("explain more"))
                {
                    if (responses.ContainsKey(lastTopic))
                    {
                        var moreResponses = responses[lastTopic];

                        BotMessage(
                            moreResponses[random.Next(moreResponses.Count)]
                        );

                        found = true;
                    }
                }
            }

            if (!found)
            {
                if (input.Contains("how are you"))
                {
                    BotMessage("I'm functioning perfectly and ready to help.");
                }

                else if (input.Contains("your purpose"))
                {
                    BotMessage("My purpose is to educate users about cybersecurity.");
                }

                else if (input.Contains("what can i ask"))
                {
                    BotMessage("You can ask about passwords, scams, phishing, and privacy.");
                }

                else if (!string.IsNullOrWhiteSpace(favouriteTopic))
                {
                    BotMessage($"Since you're interested in {favouriteTopic}, remember to review your account security settings.");
                }

                else
                {
                    BotMessage("I didn't quite understand that. Could you rephrase?");
                }
            }

            UserInput.Clear();
        }

        private void BotMessage(string message)
        {
            ChatArea.Text += $"\n[BOT]: {message}\n";
        }

        private void UserMessage(string message)
        {
            ChatArea.Text += $"\n[YOU]: {message}\n";
        }

        private void DetectSentiment(string input)
        {
            if (input.Contains("worried"))
            {
                BotMessage("Makes sense. Cybersecurity threats can be stressful.");
                BotMessage("Be cautious with suspicious links and messages.");
            }

            else if (input.Contains("frustrated"))
            {
                BotMessage("I understand your frustration. Cybersecurity can feel overwhelming sometimes.");
            }

            else if (input.Contains("curious"))
            {
                BotMessage("Curiosity is a great trait in cybersecurity.");
            }
        }

        private void ClearChat_Click(object sender, RoutedEventArgs e)
{
    ChatArea.Text = "";

    BotMessage("Chat cleared.");
}

        private void LoadAsciiArt()
        {
            AsciiArtText.Text =
@"██     ██ ███████ ██       ██████  ██████  ███    ███ ███████ ██ 
██     ██ ██      ██      ██      ██    ██ ████  ████ ██      ██ 
██  █  ██ █████   ██      ██      ██    ██ ██ ████ ██ █████   ██ 
██ ███ ██ ██      ██      ██      ██    ██ ██  ██  ██ ██         
 ███ ███  ███████ ███████  ██████  ██████  ██      ██ ███████ ██ 
                                                                 
                                                                 
                ██      █████  ███    ███                        
                ██     ██   ██ ████  ████                        
                ██     ███████ ██ ████ ██                        
                ██     ██   ██ ██  ██  ██                        
                ██     ██   ██ ██      ██                        
                                                                 
                                                                 
          ██████ ██ ██████  ██   ██ ███████ ██████               
         ██      ██ ██   ██ ██   ██ ██      ██   ██              
         ██      ██ ██████  ███████ █████   ██████               
         ██      ██ ██      ██   ██ ██      ██   ██              
██ ██ ██  ██████ ██ ██      ██   ██ ███████ ██   ██ ██ ██ ██     
                                                                 
                                                                 ";
        }

        private void PlayGreeting()
        {
            try
            {
                // SoundPlayer player =
                //     new SoundPlayer("Assets/greeting.wav");

                // player.Play();
            }
            catch
            {
                BotMessage("Voice greeting could not play.");
            }
        }
    }
}