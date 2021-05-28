using System;
using System.Collections.Generic;

#nullable disable

namespace ch.gibz.m151.uran.data.Models
{
    public partial class Comment
    {
        public Comment()
        {
            CommentLikes = new HashSet<CommentLike>();
        }

        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ExhibitId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual User Author { get; set; }
        public virtual Exhibit Exhibit { get; set; }
        public virtual ICollection<CommentLike> CommentLikes { get; set; }
    }
}
