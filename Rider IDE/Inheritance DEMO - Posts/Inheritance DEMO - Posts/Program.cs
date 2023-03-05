using System;

namespace Inheritance_DEMO___Posts
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for being arround, friends", true, "Vitor Ribeiro");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Look, the sky is beautiful!", "Vitor Ribeiro",
                "https://images.alphacoders.com/123/1230061.jpg", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost = new VideoPost("Deftones - Sextape", "Deftones",
                "https://www.youtube.com/watch?v=f0pdwd0miqs&ab_channel=Deftones", false);
            Console.WriteLine(videoPost.ToString());
        }
    }
}