using System;
using System.Collections.Generic;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Post firstPost = new Post();
            firstPost.Like();
            Console.WriteLine($"Likes: {firstPost.GetLikesNumber()}");
            firstPost.LeaveComment("Add some Comment");
            firstPost.LeaveComment("New Comment");
            Console.WriteLine($"Comments:\n{firstPost.GetComments()}");
        }
        class Post
        {
            private int likes;
            private List<string> comments = new List<string>();
            public void Like()
            {
                likes += 1;
            }
            public int GetLikesNumber()
            {
                return likes;
            }
            public void LeaveComment(string comment)
            {
                comments.Add(comment);
            }
            public string GetComments(){
                string allComments = null;
                foreach (string comment in comments){
                    allComments = allComments + comment + '\n';
                }

                return allComments;
            }
        }
    }

}
