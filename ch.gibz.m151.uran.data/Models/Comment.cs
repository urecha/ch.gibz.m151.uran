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

    /// <summary>
    /// Model of a component as is used in the client application.
    /// </summary>
    public class CommentModel
    {
        /// <summary>
        /// Comment entity id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Usersummary of the exhibitor
        /// </summary>
        //public UserSummary User { get; set; }

        /// <summary>
        /// Referred exhibit
        /// </summary>
        public int ExhibitId { get; set; }
        /// <summary>
        /// Title of the comment
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Content of the comment
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Amount of likes for this comment
        /// </summary>
        public int Likes { get; set; }

    }

    public class SimpleComment
    {
        public string Content { get; set; }
    }
}
