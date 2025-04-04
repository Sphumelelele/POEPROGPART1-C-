using System;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace POEPROPART1
{
    class Sound
    {
        public void PlaySound()
        {
            if (OperatingSystem.IsWindows())
            {
                // Play the sound
                PlaySoundForDuration("sound.wav", 5900);

                // Keep the program running until a key is pressed
                Console.WriteLine("PRESS ANY KEY FOR OUR MENU");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("This program only works on Windows.");
            }
        }

        private static void PlaySoundForDuration(string filePath, int durationMilliseconds)
        {
            try
            {
                using (SoundPlayer sound = new SoundPlayer(filePath))
                {
                    sound.Play(); // Play the sound once
                    sound.PlayLooping(); // Loop the sound

                    // Stop the sound after the specified duration
                    Task.Delay(durationMilliseconds).ContinueWith(_ =>
                    {
                        sound.Stop(); // Stop the sound

                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound: {ex.Message}");
            }
        }
    }
}
