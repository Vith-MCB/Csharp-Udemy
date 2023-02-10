using System;

namespace Inheritance_DEMO___Posts
{
    public class Post
    {
        private static int postID;
        
        //Properties
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }
        
        //Default constructor. If a derived class doesn't invoke a base-class explicity,
        //the default constructor is called implicity
        public Post()
        {
            Id = 0;
            Title = "My first post!";
            IsPublic = true;
            SendByUsername = "Vitor Ribeiro";
        }
        
        //Constructor
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.Id = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++Id;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method override of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.Id, this.Title, this.SendByUsername);
        }
    }
}