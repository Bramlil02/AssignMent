using System;
using System.Drawing;
using System.Media;

namespace AssignMent
{//start of namespace
    public class voice_logo
    {//start of class
        public string full_path = AppDomain.CurrentDomain.BaseDirectory;

        public voice_logo()
        {//start of constructor

            //Creating sound Player
            SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\AssignMent\\AssignMent\\Resources\\greet.wav");

            //Playing the sound 
            player.PlaySync();

            Console.WriteLine("");


        }//end of constructor

    }//end of class
}//end of namespace
