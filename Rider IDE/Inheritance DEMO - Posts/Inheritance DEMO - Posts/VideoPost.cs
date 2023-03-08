using System;
using System.Threading;

namespace Inheritance_DEMO___Posts
{
    public class VideoPost : Post
    {
        //Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        
        //Properties
        protected string VideoURL { get; set; }
        protected int VideoLenght { get; set; }
        
        public VideoPost(){}

        public VideoPost(string title, string sendByUsername,
            string videoUrl, bool isPublic, int videoLenght)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            //Image URL is a member of Image Post, but not from post
            this.VideoURL = videoUrl;
            this.VideoLenght = videoLenght;
        }

        public override string ToString()
        {
            if (IsPublic)
            {
                return String.Format("{0} - {1} - by {2} - Link: {3}", this.Id,
                    this.Title, this.SendByUsername, this.VideoURL);
            }
            else
            {
                return String.Format("{0} IS PRIVATE VIDEO!",this.Title);
            }
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            else
            {
                Console.WriteLine("Video is already been played!");
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        private void TimerCallback(Object obj)
        {
            if (currDuration < VideoLenght)
            {
                currDuration++;
                Console.WriteLine("{0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
    }
}