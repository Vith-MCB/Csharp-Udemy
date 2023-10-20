using System;

namespace Inheritance_DEMO___Posts
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }
        
        public ImagePost(){}

        public ImagePost(string title, string sendByUsername, string imageUrl, bool isPublic)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            
            //Image URL is a member of Image Post, but not from post
            this.ImageURL = imageUrl;
        }
        
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - Link: {3}", this.Id, this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}