using System;
using System.Collections.Generic;

#nullable disable

namespace ch.gibz.m151.uran.data.Models
{
    public partial class User
    {
        public User()
        {
            CommentLikes = new HashSet<CommentLike>();
            Comments = new HashSet<Comment>();
            ExhibitLikes = new HashSet<ExhibitLike>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public virtual ICollection<CommentLike> CommentLikes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ExhibitLike> ExhibitLikes { get; set; }
    }
}
