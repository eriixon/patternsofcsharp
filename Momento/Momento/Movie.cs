using System;
using System.Timers;

namespace Momento
{
    public class Movie
    {
        private int position;
        private Timer timer;

        public string Name { get; set; }
        public int Length { get; set; }

        public Movie()
        {
            timer = new Timer(1000);
            timer.Elapsed += progress;
        }

        public void Play()
        {
            if (position >= Length) position = 0;
            Console.WriteLine($" {Name} starting to play at {position} seconds");
            timer.Start();
        }

        public void Stop()
        {
            Console.WriteLine($" {Name} stoping to play at {position} seconds");
            timer.Stop();
        }

        public MovieState GetState()
        {
            return new MovieState()
            {
                Name = Name,
                Position = position,
                Length = Length
            };
        }
        public void SetState(MovieState state)
        {
            Name = state.Name;
            Length = state.Length;
            position = state.Position;            
        }

        public void progress(object sender, ElapsedEventArgs e)
        {
            position += 1;
            if (position >= Length) Stop();
        }
    }
}
