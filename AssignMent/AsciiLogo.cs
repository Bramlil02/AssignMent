using System;
using System.IO;
using System.Drawing;

namespace AssignMent
{


    public class AsciiLogo
    {
        public AsciiLogo()
        {
            string logo_p = AppDomain.CurrentDomain.BaseDirectory;

            string path = logo_p.Replace("bin\\Debug\\", ""); // Adjust the path to point to the Resources folder

            string file_location = Path.Combine(path, "logo.jpg");

            if (File.Exists(file_location))
            {
                Console.WriteLine(" Logo location not found at: " + file_location);
                

            }
            Bitmap image = new Bitmap(file_location);

            image = new Bitmap(image, new Size(100, 50)); // Resize the image to fit the console

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // Convert to grayscale
                    char asciiChar = gray < 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@'; // Choose character based on brightness
                    Console.Write(asciiChar); // Print the character

                }
                Console.WriteLine(); // Move to the next line after each row
            }
            Console.WriteLine(); // Add an extra line after the logo

        }
    }

}

