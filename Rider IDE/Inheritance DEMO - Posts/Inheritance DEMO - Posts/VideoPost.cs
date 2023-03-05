using System;

namespace Inheritance_DEMO___Posts
{
    public class VideoPost : Post
    {
        public string VideoURL { get; set; }



        //Generic Constructor
        public VideoPost()
        {
            Id = 0;
            Title = "This is a generic Video!";
            IsPublic = false;
            SendByUsername = "YouTube";
            VideoURL = "https://youtube.com/";
        }

        public VideoPost(string title, string sendByUsername,
            string videoUrl, bool isPublic)
        {
            this.Id = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            //Image URL is a member of Image Post, but not from post
            this.VideoURL = videoUrl;
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
    }
}