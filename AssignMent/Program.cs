using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent
{//Start of namespace
    public class Program
    {//Start of class
        static void Main(string[] args)
        {//Start of method
            // The constructor of voice_logo will run automatically
            new voice_logo() { };

            // The constructor displays my ASCII art logo
            new AsciiLogo() { };

            // This is where your chatbot logic runs
            human_interraction AssignMent = new human_interraction();

        }//end of method
    }//end of class
}//end of namespace
