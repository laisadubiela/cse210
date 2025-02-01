using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        private readonly string _title;
        private readonly string _author;
        private readonly int _seconds;
        private readonly List<Comment> _comments;

        public Video(string title, string author, int seconds)
        {
            _title = title;
            _author = author;
            _seconds = seconds;
            _comments = new List<Comment>();
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetSeconds()
        {
            return _seconds;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }

    public class Comment
    {
        private readonly string _name;
        private readonly string _comment;

        public Comment(string name, string comment)
        {
            _name = name;
            _comment = comment;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetComment()
        {
            return _comment;
        }
    }
}
