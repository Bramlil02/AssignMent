using System;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using System.Collections;

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
            Console.WriteLine("          PETER CYBERSECURITY AWARENESS BOT         ");
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

            //-----ARRAYLIST-----

            //This will store all password answers
            ArrayList answers = new ArrayList();

            //This will store all password answers
            ArrayList ignoreWords = new ArrayList();


            //Adding Data using the Add method

            //Adding answers to the lists
                answers.Add("PBot: You can ask me about passwords, phishing, and safe browsing.");
                answers.Add("PBot: Im good how are you.");
                answers.Add("PBot: Thats good to hear! How can I assist you with cybersecurity today?"); 
                answers.Add("PBot:  My purpose is to teach you about cybersecurity and how to stay safe online.");
                answers.Add("PBot: Use strong password with letters, numbers, and symbols. Never share your password!");
                answers.Add("PBot: Phishing is when attackers trick you into giving personal info. Always check emails and links carefully.");
                answers.Add("PBot: Only visit secure websites (https://) and avoid clicking suspicious links.");
                answers.Add("PBot: Sorry, I dont understand.Could you repharse? or just stick to cybersecurity topics.");

            //Adding ignore words to the lists
                ignoreWords.Add("hi");
                ignoreWords.Add("whats up");
                ignoreWords.Add("Heyyyyyy");
                ignoreWords.Add("Whats good");
                ignoreWords.Add("hello");
                ignoreWords.Add("Sup");
                ignoreWords.Add("dope");


            // Infinite loop to keep chatbot running
            while (true)
            {
                // Display "UserName" prompt
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(UserName + ": ");
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




                if (UInput.Contains("what can i ask"))
                {
                    Console.WriteLine("PBot: You can ask me about passwords, phishing, and safe browsing.");

                    }
                    //exit condition 
                    if (UInput == "exit")
                    {
                        Console.WriteLine("PBot: Goodbye! Stay Safe online");
                        break;// Stop the loop
                    }
                //Basic Response
                if (UInput.Contains("How are you"))
                {
                    Console.WriteLine("PBot: Im good how are you.");
                }
                else if(UInput.Contains("Im good"))
                {
                    Console.WriteLine("PBot: Thats good to hear! How can I assist you with cybersecurity today?");
                }
                    
                    else if (UInput.Contains("purpose"))
                    {
                        Console.WriteLine("PBot: My purpose is to teach you about cybersecurity and how to stay safe online.");

                    }
                    else if (UInput.Contains("what can i ask"))
                    {
                        Console.WriteLine("PBot: You can ask me about passwords, phishing, and safe browsing.");
                    }
                    //Cybersecurity topics 
                    else if (UInput.Contains("password"))
                    {
                        Console.WriteLine("PBot: Use strong password with letters, numbers, and symbols. Never share your password!");

                    }
                    else if (UInput.Contains("phishing"))
                    {
                        Console.WriteLine("PBot: Phising is when attackers trick you into giving personal info. Always check emails and links carefully.");

                    }
                    else if (UInput.Contains("SafeBrowsing"))
                    {
                        Console.WriteLine("PBot: Only visit secure websites (https://) and avoid clicking suspicious links.");
                    }
                    //If you enter an Unknown input 
                    else
                    {
                        Console.WriteLine("PBot: Sorry, I dont understand.Could you repharse? or just stick to cybersecurity topics.");
                        Console.ResetColor();
                    }
                }
            }

        }
    }
