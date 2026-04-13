using System;
using System.Diagnostics.Eventing.Reader;
using System.Threading;

namespace AssignMent
{//start of namespace

  
    public class human_interraction
    {//start class

        //This is the Constructor Runs automatically when object is created
        public human_interraction()
        {
            // Display header/title
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=================================================================");
            Console.WriteLine("            CYBERSECURITY AWARENESS BOT         ");
            Console.WriteLine("=================================================================");
            Console.ResetColor();
            Console.WriteLine();

            // Ask user for their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please enter your name: ");
            string UserName = Console.ReadLine(); // Store user input
            Console.ResetColor();

            // Greeting the user
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello, " + UserName + " Welcome to the Cybersecurity Awareness Bot. !");
            Console.ResetColor();

            Console.WriteLine();

            // Instruction for exiting the chatbot
            Console.WriteLine(" You are welcome type 'exit' to Quite.");

            // Infinite loop to keep chatbot running
            while (true)
            {
                // Display "You:" prompt
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You: ");
                Console.ResetColor();

                // Read user input and convert to lowercase
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string UInput = Console.ReadLine().ToLower();
                Console.ResetColor();

                // Check for empty input
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (string.IsNullOrEmpty(UInput))
                {
                    
                    Console.WriteLine("Bot: You didnt type anything. Please enter a question. ");
                   
                    //Going back to the start of the loop
                    continue;

                }
                UInput = UInput.ToLower();


                //exit condition 
                if (UInput == "exit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay Safe online");
                    break;// Stop the loop
                }
                //Basic Response
                if (UInput.Contains("how are you"))
                {
                    Console.WriteLine("Bot: Im just a bot , im just here to assist you to stay safe online!");

                }
                else if (UInput.Contains("purpose"))
                {
                    Console.WriteLine("Bot: My purpose is to teach you about cybersecurity and how to stay safe online.");

                }
                else if (UInput.Contains("what can i ask"))
                {
                    Console.WriteLine("Bot: You can ask me about passwords, phishing, and safe browsing.");
                }
                //Cybersecurity topics 
                else if (UInput.Contains("password"))
                {
                    Console.WriteLine("Bot: Use strong password with letters, numbers, and symbols. Never share your password!");

                }
                else if (UInput.Contains("phishing"))
                {
                    Console.WriteLine("Bot: Phising is when attackers trick you into giving personal info. Always check emails and links carefully.");

                }
                else if (UInput.Contains("SafeBrowsing"))
                {
                    Console.WriteLine("Bot: Only visit secure websites (https://) and avoid clicking suspicious links.");
                }
                //If you enter an Unknown input 
                else
                {
                    Console.WriteLine("Bot: Sorry, I dont understand.Could you repharse? or just stick to cybersecurity topics.");
                    Console.ResetColor();
                }
            }
        }
       
    }
}