using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPROPART1
{
    class Pictures
    {
        public void DisplayPicture(string imagePath)
        {
            // Path to the image file
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (!File.Exists(imagePath))
            {
                Console.WriteLine("Image file not found: " + imagePath);
                return;
            }
            // Load the image
            Bitmap image = new Bitmap(imagePath);

            // Resize the image to fit the console window
            int newWidth = 40; // Adjust based on your console width
            int newHeight = (int)(image.Height * ((double)newWidth / image.Width));
            Bitmap resizedImage = new Bitmap(image, newWidth, newHeight);

            // ASCII characters ordered by brightness (dark to light)
            string asciiChars = "-#* ";

            // Convert each pixel to ASCII
            for (int y = 0; y < resizedImage.Height; y++)
            {
                for (int x = 0; x < resizedImage.Width; x++)
                {
                    Color pixelColor = resizedImage.GetPixel(x, y);
                    int brightness = (int)(pixelColor.GetBrightness() * (asciiChars.Length - 1));
                    char asciiChar = asciiChars[brightness];
                    Console.Write(asciiChar);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = originalColor;

        }
    }
}
