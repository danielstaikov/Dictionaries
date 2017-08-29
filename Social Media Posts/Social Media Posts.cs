using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Posts
{
    class Program
    {
        static Dictionary<string, Dictionary<string, string>> postComment;
        static Dictionary<string, int> postLikes;
        static Dictionary<string, int> postDislikes;

        static void Main(string[] args)
        {
            postComment = new Dictionary<string, Dictionary<string, string>>();
            postLikes = new Dictionary<string, int>();
            postDislikes = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "drop the media")
            {
                string[] inputToken = input.Split(' ');
                string command = inputToken[0];
                string postName = inputToken[1];

                switch (command)
                {
                    case "post":
                    {
                            CreatePost(postName);
                            break;
                    }
                    case "like":
                    {
                            LikePost(postName);
                            break;
                    }
                    case "dislike":
                    {
                            DislikePost(postName);
                         break;
                    }
                    case "comment":
                    {
                            string commentatorName = inputToken[2];
                            string content = string.Join(" ", inputToken.Skip(3));
                            CommentPost(postName, commentatorName, content);
                        break;
                    }
                     
                }

                input = Console.ReadLine();
            }
            foreach (var postCommentData in postComment)
            {
                string postName = postCommentData.Key;
                int likes = postLikes[postName];
                int dislikes = postDislikes[postName];
                Dictionary<string, string> commentsData = postCommentData.Value;

                Console.WriteLine(  $"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");

                Console.WriteLine("Comments:");

                if (commentsData.Count == 0)
                {
                    Console.WriteLine("None");
                }
                foreach (var commentData in commentsData)
                {
                    string commentatorName = commentData.Key;
                    string commentContent = commentData.Value;
                    Console.WriteLine($"*  {commentatorName}: {commentContent}");
                }
            }

        }
        static void CreatePost(string postName)
        {
            postComment.Add(postName, new Dictionary<string, string>());
            postLikes.Add(postName, 0);
            postDislikes.Add(postName, 0);

        }
        static void LikePost(string postName)
        {
            postLikes[postName]++;
        }
        static void DislikePost(string postName)
        {
            postDislikes[postName]++;

        }
        static void CommentPost(string postName, string commentatorName, string commentContent)
        {
            postComment[postName].Add(commentatorName, commentContent);

        }
    }
}
