using System;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class Post
        {
            private int likes;
            private string[] comments;
            public void Like()
            {
                likes += 1;
            }
            public int GetLikesNumber()
            {
                return likes;
            }
            public void LeaveComment()
        }
    }

}
