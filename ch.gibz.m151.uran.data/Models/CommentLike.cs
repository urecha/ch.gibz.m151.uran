using System;
using System.Collections.Generic;

#nullable disable

namespace ch.gibz.m151.uran.data.Models
{
    public partial class CommentLike
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual User User { get; set; }
    }
}
