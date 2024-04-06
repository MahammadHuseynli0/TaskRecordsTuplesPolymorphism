using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Blog
    {
        private static int _id;
        public int Id { get; set; }
        private string _description;
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length > 5)
                {

                    _title = value;

                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value.Length > 8)
                {

                    _description = value;

                }
            }
        }

        public Comment[] Comments = new Comment[] { };
        public Comment[] FilteredComments = new Comment[] { };


        public Blog(string title, string description)
        {
            _id++;
            Id = _id;
            _title = title;
            _description = description;
        }
        public override string ToString()
        {
            return $"Title {Title} Description {Description}";

        }
        public Comment GetComment(int commentid)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentid)
                {
                    return Comments[i];
                }
            }
            return null;
        }
        public Comment[] GetAllComments()
        {
            return Comments;
        }


        public void AddComment(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length + 1);
            Comments[Comments.Length - 1] = comment;
        }


        public void RemoveComment(int commentid)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id! == commentid)
                {

                    Array.Resize(ref Comments, Comments.Length + 1);
                    Comments[Comments.Length - 1] = Comments[i];
                }
            }
            FilteredComments = Comments;
        }

        public void UptadeComment(int commentid, Comment comment)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentid)
                {
                    Comments[i] = comment;
                }

            }
        }
    }
}
