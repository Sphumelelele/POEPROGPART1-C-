// See https://aka.ms/new-console-template for more information
using System;
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
            Console.WriteLine($"\nWELCOME {name?.ToUpper()} TO OUR MENU HERE YOU CAN GET INFORMED ABOUT CYBERSECURITY\n");
         
            bool keepShowMenu = true;
            while (keepShowMenu)
            {
                keepShowMenu = Search();
            }


        }
        public static bool Search()
        {
            Pictures image = new Pictures();

            List<string> list = new List<string>()
{
    "phishing \n a cyberattack where scammers trick people into revealing sensitive information (passwords, banking details, etc.)\n by pretending to be a trusted entity (e.g., a bank, company, or government).\r\n\nWays to Prevent Phishing:\r\n\r\n    Verify Emails & Links – Check sender details and hover over links before clicking.\r\n\r\n    Use Strong, Unique Passwords – Avoid using the same password across different sites.\r\n\r\n    Enable Multi-Factor Authentication (MFA) – Adds an extra layer of security.\r\n\r\n    Avoid Downloading Unknown Attachments – Could contain malware.\r\n\r\n    Stay Updated – Keep software and antivirus programs up to date.\r\n\r\n    Be Skeptical of Urgent Requests – Scammers use urgency to trick victims.\r\n\r\n    Educate Yourself & Others – Awareness is key to avoiding phishing scams.\n",
    "malware \n(malicious software) is a program designed to harm, exploit, or disrupt devices, networks, or data. It \nincludes viruses, worms, ransomware, spyware, and trojans.\r\n\nWays to Prevent Malware:\r\n\r\n    Install Antivirus & Keep It Updated – Detects and removes threats.\r\n\r\n    Avoid Suspicious Links & Attachments – Malware often spreads through emails or fake websites.\r\n\r\n    Use Strong & Unique Passwords – Prevents unauthorized access.\r\n\r\n    Enable Automatic Updates – Keeps software secure from vulnerabilities.\r\n\r\n    Download Only from Trusted Sources – Avoid third-party or pirated software.\r\n\r\n    Use a Firewall – Blocks unauthorized network access.\r\n\r\n    Back Up Data Regularly – Protects against data loss from ransomware.\n",
    "trojan horse \n A Trojan Horse virus is a type of malware that disguises itself as a legitimate file or program to trick users\n into downloading and running it. Once activated, it can steal data, damage files, or allow hackers to control\n your system.\r\n\nWays to Prevent Trojan Horse Viruses:\r\n\r\n    Avoid Suspicious Downloads – Only download software from trusted sources.\r\n\r\n    Use Antivirus Software – Keep it updated and run regular scans.\r\n\r\n    Enable Firewall – It helps block unauthorized access.\r\n\r\n    Be Cautious with Email Attachments – Avoid opening unknown or unexpected attachments.\r\n\r\n    Keep Software Updated – Ensure your OS and apps have the latest security patches.\r\n\r\n    Disable Auto-Run for External Devices – Prevents malware from running automatically.\r\n\r\n    Use Strong Passwords – Helps protect your accounts from unauthorized access.\n",
    "strong passwords\n is a secure and hard-to-crack password that protects accounts from hacking attempts.\r\n\nWays to Create a Strong Password:\r\n\r\n    Use 12–16+ Characters – Longer passwords are harder to crack.\r\n\r\n    Mix Uppercase, Lowercase, Numbers & Symbols – (e.g., T@ke5eCur!ty)\r\n\r\n    Avoid Common Words & Personal Info – No “password123” or birthdates.\r\n\r\n    Use a Passphrase – A random mix of words (e.g., \"Giraffe#Cloud9&Moon!\").\r\n\r\n    Make It Unique for Each Account – Don’t reuse passwords.\r\n\r\n    Use a Password Manager – Stores and generates strong passwords.\r\n\r\n    Enable Multi-Factor Authentication (MFA) – Adds extra security. \n"
};

            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("PlEASE SEARCH BY NAME AS SEEN IN THE MENU\n");
            Console.WriteLine("\n════════════════════════════════════════════════════════════");
            Console.WriteLine("                       SECURITY MENU                        ");
            Console.WriteLine("════════════════════════════════════════════════════════════");
            Console.WriteLine("  [1] PHISHING");
            Console.WriteLine("  [2] MALWARE");
            Console.WriteLine("  [3] TROJAN HORSE");
            Console.WriteLine("  [4] STRONG PASSWORDS");
            Console.WriteLine("  [0] EXIT PRESS THE X ON TOP RIGHT CORNER");
            Console.WriteLine("════════════════════════════════════════════════════════════");

            Console.ForegroundColor = originalColor;
           

             Console.WriteLine("\n");
            Console.WriteLine("ENTER YOUR CHOICE\n");
            string? search = Console.ReadLine()?.ToLower();
            Console.WriteLine("\n");

            foreach (string item in list)
                {
                    if (item.StartsWith(search ?? string.Empty))
                    {
                        image.DisplayPicture($"{search}.jpg");

                    Console.WriteLine("\n");
                    TypeWriterEffect(item, 30, ConsoleColor.White);
                    Console.WriteLine("\n");

                    Console.WriteLine("\n");

                    return true;

                    }
                }


            Console.WriteLine("\nSEARCH INVALID - PLEASE CHOOSE FROM THE ITEMS ABOVE");

     
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
    }
}





