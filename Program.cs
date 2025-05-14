// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
namespace POEPROPART1
{

    public class Program
    {
        public static void Main(string[] args)
        {


            Sound greeting = new Sound();
            greeting.PlaySound();
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n**************************************************************");
            Console.WriteLine("\nPLEASE WRITE YOUR NAME:");
            Console.WriteLine("\n**************************************************************");
            Console.ForegroundColor = originalColor;
            string? name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {

                Console.WriteLine("Invalid name. Please enter a valid name.");
                name = Console.ReadLine();
            }

            Console.WriteLine($"\nWELCOME {name?.ToUpper()} TO OUR MENU HERE YOU CAN GET INFORMED ABOUT CYBERSECURITY\n");
            Console.WriteLine("\n");
         
            bool keepShowMenu = true;
            while (keepShowMenu)
            {
                keepShowMenu = Search();
                DisplayConversationFlawstring(name);
                
            }


        }




        public static bool Search()
        {
            Pictures image = new Pictures();
            Dictionary<string, string> list = new Dictionary<string, string>
        {
            { "phishing", @"
A cyberattack where scammers trick people into revealing sensitive information (passwords, banking details, etc.)
by pretending to be a trusted entity (e.g., a bank, company, or government). if you want more about phishing type more about phishing 
"},
  {"sensitive information", @"
Ways to Prevent Phishing:

    - Verify Emails & Links – Check sender details and hover over links before clicking.
    - Use Strong, Unique Passwords – Avoid using the same password across different sites.
    - Enable Multi-Factor Authentication (MFA) – Adds an extra layer of security.
    - Avoid Downloading Unknown Attachments – Could contain malware.
    - Stay Updated – Keep software and antivirus programs up to date.
    - Be Skeptical of Urgent Requests – Scammers use urgency to trick victims.
    - Educate Yourself & Others – Awareness is key to avoiding phishing scams.
" },
            { "malware", @"
(Malicious software) is a program designed to harm, exploit, or disrupt devices, networks, or data.
It includes viruses, worms, ransomware, spyware, and trojans.if you want more about malware type more about malware
" },
 { "protect from malicious software" ,@"
Ways to Prevent Malware:

    - Install Antivirus & Keep It Updated – Detects and removes threats.
    - Avoid Suspicious Links & Attachments – Malware often spreads through emails or fake websites.
    - Use Strong & Unique Passwords – Prevents unauthorized access.
    - Enable Automatic Updates – Keeps software secure from vulnerabilities.
    - Download Only from Trusted Sources – Avoid third-party or pirated software.
    - Use a Firewall – Blocks unauthorized network access.
    - Back Up Data Regularly – Protects against data loss from ransomware.
" },
            { "trojan horse", @"
A Trojan Horse virus is a type of malware that disguises itself as a legitimate file or program to trick users
into downloading and running it. Once activated, it can steal data, damage files, or allow hackers to control
your system." },

 {"Avoid Suspicious download", @"
Ways to Prevent Trojan Horse Viruses:

    - Avoid Suspicious Downloads – Only download software from trusted sources.
    - Use Antivirus Software – Keep it updated and run regular scans.
    - Enable Firewall – It helps block unauthorized access.
    - Be Cautious with Email Attachments – Avoid opening unknown or unexpected attachments.
    - Keep Software Updated – Ensure your OS and apps have the latest security patches.
    - Disable Auto-Run for External Devices – Prevents malware from running automatically.
    - Use Strong Passwords – Helps protect your accounts from unauthorized access.
" },
            { "strong passwords", @"
A secure and hard-to-crack password that protects accounts from hacking attempts.
"},

 {"vaild signin",@"
Ways to Create a Strong Password:

    - Use 12–16+ Characters – Longer passwords are harder to crack.
    - Mix Uppercase, Lowercase, Numbers & Symbols – (e.g., T@ke5eCur!ty)
    - Avoid Common Words & Personal Info – No “password123” or birthdates.
    - Use a Passphrase – A random mix of words (e.g., ""Giraffe#Cloud9&Moon!"").
    - Make It Unique for Each Account – Don’t reuse passwords.
    - Use a Password Manager – Stores and generates strong passwords.
    - Enable Multi-Factor Authentication (MFA) – Adds extra security.
" },
                    { "ransomware", @"
Malware that encrypts files and demands payment for decryption.
" },
  {"tips on danagerous threats", @"
**Prevention Tips:**
✔ Maintain offline/cloud backups of critical data.  
✔ Avoid clicking suspicious links in emails.  
✔ Patch systems regularly to fix vulnerabilities.  
✔ Restrict user permissions (least privilege principle).  
✔ Use endpoint detection tools (e.g., CrowdStrike).  
" },


};

            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("PlEASE SEARCH BY NAME AS SEEN IN THE MENU\n");
            Console.WriteLine("\n════════════════════════════════════════════════════════════");
            Console.WriteLine("                       SECURITY MENU                        ");
            Console.WriteLine("════════════════════════════════════════════════════════════");
            Console.WriteLine("  [1] PHISHING");
            Console.WriteLine("  [2] protect sensitive information(random responses phishing tips)");
            Console.WriteLine("  [3] MALWARE");
            Console.WriteLine("  [4] protect from malicious software(random responses malware tips)");
            Console.WriteLine("  [5] TROJAN HORSE");
            Console.WriteLine("  [6] Avoid Suspicious download(random  responses trojan horse tip)");
            Console.WriteLine("  [7] STRONG PASSWORDS");
            Console.WriteLine("  [8] vaild signin (random  responses strong password tips)");
            Console.WriteLine("  [9]  RANSOMWARE");
            Console.WriteLine("  [10] tips on danagerous threats (random  responses ransomware tip)");
            Console.WriteLine("  [11] EXIT PRESS THE X ON TOP RIGHT CORNER");
            Console.WriteLine("  [12] sentiment detection i used worried, furious,curious,worried,happy,sad ");
            Console.WriteLine("════════════════════════════════════════════════════════════");

            Console.ForegroundColor = originalColor;
           

             Console.WriteLine("\n");
            Console.WriteLine("TYPE THE NAME YOU WANT TO SEARCH AS IT IS ON THE MENU\n");
            string? search = null;
            List<string> history = new List<string>();

            var inputTimer = new System.Timers.Timer(45000); // 45 seconds
            inputTimer.Elapsed += (sender, e) =>
            {
                if (string.IsNullOrEmpty(search))
                {
                    Console.WriteLine("\nAre you confused? Type your question and press Enter.");
                }
            
            };
            inputTimer.AutoReset = false; 
            inputTimer.Start();

          
            search = Console.ReadLine()?.ToLower();
            inputTimer.Stop(); 

            Console.WriteLine("\n");

            TrackingEmotion(search);
            history.Add(search);
            foreach (var item in list)
            {
               
                if (search.Contains(item.Key.ToLower()) && search != null)
                {
                    if (history.Contains(search))
                    {
                        Console.WriteLine($"I remember you have asked about {search} before. Thank you for being curious!");
                    }

                    image.DisplayPicture($"{item.Key}.jpg");
                    Console.WriteLine("\n");
                    TrackingEmotion(search);
                    Console.WriteLine("\n");
                    TypeWriterEffect(item.Value, 30, ConsoleColor.White);
                    Console.WriteLine("\n");

                    return true;
                }
            }



            Console.WriteLine("\nSEARCH INVALID - PLEASE CHOOSE FROM THE ITEMS BELOW ");
            Console.WriteLine("\n");
     
            return true;
        
        }






        public static void TypeWriterEffect(string text, int delay = 18, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(delay);

                // Speed up for spaces and newlines
                if (c == ' ' || c == '\n')
                {
                    System.Threading.Thread.Sleep(delay / 2);
                }
            }
            Console.ForegroundColor = originalColor;
        }





        public static void DisplayConversationFlawstring(string name)
        {
            Random random = new Random();
            int index = random.Next(0, 5); // Adjust the range based on the number of responses
            string[] responses = {
                $"hey {name} you can always asK more questions we even have tips on (insider threats,zero_day,mitm,ransomware,social engineering)",
                $"{name} thank for your wonderfull questions are you learning.",
                $"{name} the more you ask the more you learn",
                $"Think before you share no no no why think {name} while you can ask more questions if you curios.",
                $"{name} I hope you filled with the most wonderfull information."
            };
           

            Console.WriteLine(responses[index]);
           
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }





        public static void TrackingEmotion(string search)
        {
            Dictionary<string, string> emotionResponses = new Dictionary<string, string>
            {
                {"curious","so wonderfull that you curious" },
                {"furious","it understandable that you angry" },
                {"worried","don't worry i'm here ask me about cybersecurity concepts" },
                {"happy" ,"its a delight to here that"},
                {"sad","sorry i hope things go well so your life is gone get light up"}

            };

            foreach(var Responses in emotionResponses)
            {
                if (search.Contains(Responses.Key.ToLower())){
                    TypeWriterEffect(Responses.Value, 30, ConsoleColor.White);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                }
            }
        }
        


     
    }
}





