using System;
using System.Threading;

namespace StudyTimer
{
    class MyTimer
    {
        private static System.Timers.Timer timer;
        private static System.Media.SoundPlayer player;
        private static int seconds;
        private static int minutes;
        private static int hours;

        public MyTimer()
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
            timer = new System.Timers.Timer(1000);
        }
        public void SetTimer()
        {
            timer.Enabled = true;
            timer.Elapsed += OnTimedEvent;
        }

        public void KillTimer()
        {
            timer.Stop();
            timer.Dispose();
        }

        public static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                seconds = 0;
                minutes += 1;
            }

            // take a break
            if ((minutes == 25 || minutes == 55) && seconds == 0)
            {
                PlaySound();
            }

            // back to work
            if (minutes == 30 && seconds == 0) { PlaySound(); }

            if (minutes > 59) { PlaySound(); minutes = 0; hours += 1; }

            Console.Clear();
            Console.WriteLine("Press enter to stop the application");
            Console.WriteLine("Time elapsed: {0}:{1}:{2}", hours, minutes, seconds);
        }

        private static void PlaySound()
        {
            player = new System.Media.SoundPlayer(@"C:\Sounds\buzzer.wav");
            player.Play();
        }
    }
}
