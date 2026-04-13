using System;
using System.Drawing;
using System.Media;

namespace AssignMent
{
    internal class voice_logo
    {
        public string full_path = AppDomain.CurrentDomain.BaseDirectory;

        public voice_logo()
        {

            //Creating sound Player
            SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\AssignMent\\AssignMent\\Resources\\greet.wav");

            //Playing the sound 
            player.PlaySync();

            Console.WriteLine("");


    }//end of class

    }
}
